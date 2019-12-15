using SmoBL.Model;
using System.Threading.Tasks;

namespace SmoBL.Controller
{
    /// <summary>
    ///Контроллер системы массового обслуживания.
    /// </summary>
    public class QueueingSystemController
    {
        private QueueingSystem queueingSystem;
        private StatisticController statisticController;
        private SourceController sourceController;

        public QueueingSystemController(QueueingSystem queueingSys,
                                        StatisticController statisticContrl,
                                        SourceController sourceContrl)
        {
            queueingSystem = queueingSys;
            sourceController = sourceContrl;
            statisticController = statisticContrl;
        }
        
        /// <summary>
        /// Добавление заявки в систему для решения вопроса обслуживания.
        /// </summary>
        public void AddRequest(Request request)
        {
            statisticController.AddAllRequest();
            if(queueingSystem.Queue.Count > 0)
            {
                if (CheckFreeChannel(out int index))
                {
                    queueingSystem.Channel[index].AddRequest(queueingSystem.Queue[0]);
                    queueingSystem.Queue.RemoveAt(0);
                }
            }

            if(queueingSystem.Queue.Count == 0 && CheckFreeChannel(out int ind))
            {
                queueingSystem.Channel[ind].AddRequest(request);
            }

            else if(queueingSystem.Queue.Count < queueingSystem.QueueCapacity)
            {
                queueingSystem.Queue.Add(request);
            }
            else
            {
                statisticController.AddNotServicedRequest();
            }
        }

        /// <summary>
        /// Проверка на наличие пустых каналов.
        /// </summary>
        /// <returns></returns>
        private bool CheckFreeChannel(out int ind)
        {
            ind = -1;
            for (var i = 0; queueingSystem.CountChannel > i; i++)
            {
                if(queueingSystem.Channel[i].Channel.CurRequest == null)
                {
                    ind = i;
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Запуск асинхронного метода для симуляции.
        /// </summary>
        /// <param name="processingTime">Время обслуживания заявки.</param>
        public async void SystemOnlineAsync(float processingTime)
        {
            await Task.Run(() => SystemOnline(processingTime));
        }
        /// <summary>
        /// Главный метод симуляции (создание и обаботка заявок).
        /// </summary>
        /// <param name="processingTime">Время обслуживания заявки.</param>
        public void SystemOnline(float processingTime)
        {
            ulong timer = 0;
            ulong lastSpawn = 0;
            while(sourceController.IsOnline)
            {
                if (sourceController.Source.SpawnDelay < timer - lastSpawn)
                {
                    lastSpawn = timer;
                    AddRequest(sourceController.SpawnRequest(processingTime));
                }

                Processing();                
                timer++;
            }
        }
        /// <summary>
        /// Обработка заявок в каналах.
        /// </summary>
        private void Processing()
        {
            for (var i = 0; i < queueingSystem.CountChannel; i++)
            {
                var ch = queueingSystem.Channel[i];
                if (ch.Channel.CurRequest != null && ch.Channel.Timer < ch.Channel.CurRequest.ProcessingTime)
                {
                    ch.Channel.Timer++;
                }
                else if (ch.Channel.CurRequest != null)
                {
                    statisticController.AddTimeInSystem(ch.Channel.CurRequest.TimeInSystem + 
                                                        ch.Channel.CurRequest.ProcessingTime);
                    ch.Channel.CurRequest = null;
                    ch.Channel.Timer = 0;
                    statisticController.AddServicedRequest();
                }
            }
            QueueProcessing();
        }

        /// <summary>
        /// Подсчет времени в очереди.
        /// </summary>
        private void QueueProcessing()
        {
            foreach(var item in queueingSystem.Queue)
            {
                item.TimeInSystem++;
            }
        }
    } 
}
