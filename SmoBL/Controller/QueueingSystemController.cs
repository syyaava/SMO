using SmoBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoBL.Controller
{
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
            if(queueingSystem.Queue.Count == 0 && CheckFreeChannel(out int ind))
            {
                queueingSystem.Channel[ind].AddRequest(request);
            }
            else if(queueingSystem.Queue.Count < queueingSystem.QueueCapacity)
            {
                queueingSystem.Queue.Add(request);
                //TODO: сделать чтобы из очереди шли в каналы
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

        public async void SystemOnlineAsync()
        {
            await Task.Run(() => SystemOnline());
        }

        public void SystemOnline()
        {
            ulong timer = 0;
            ulong lastSpawn = 0;
            while(sourceController.IsOnline)
            {
                if (sourceController.Source.SpawnDelay < timer - lastSpawn)
                {
                    AddRequest(sourceController.SpawnRequest());
                }

                Processing();
                timer++;
            }
        }

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
                    ch.Channel.CurRequest = null;
                    statisticController.AddServicedRequest();
                }
            }
        }
    } 
}
