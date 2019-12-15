using SmoBL.Model;
using System.Windows.Forms;

namespace SmoBL.Controller
{
    /// <summary>
    /// Контроллер статистики.
    /// </summary>
    public class StatisticController
    {
        /// <summary>
        /// Статистика СМО.
        /// </summary>
        Statistic Statistic;

        public StatisticController(RichTextBox richTextBox)
        {
            Statistic = new Statistic(richTextBox);
        }

        /// <summary>
        /// Увеличить общее число заявок на 1;
        /// </summary>
        public void AddAllRequest()
        {
            Statistic.CountAllRequest++;
        }

        /// <summary>
        /// Увеличить число обслуженных заявок на 1;
        /// </summary>
        public void AddServicedRequest()
        {
            Statistic.CountServicedRequest++;
        }

        /// <summary>
        /// Увеличить число необслуженных заявок на 1;
        /// </summary>
        public void AddNotServicedRequest()
        {
            Statistic.CountNotServicedRequest++;
        }
        /// <summary>
        /// Получить статистику СМО.
        /// </summary>
        /// <returns></returns>
        public string GetStatistic()
        {
            return Statistic.ToString();
        }
        /// <summary>
        /// Увеличить общее время в системе.
        /// </summary>
        /// <param name="time"></param>
        public void AddTimeInSystem(float time)
        {
            Statistic.TimeAllRequestInSys += time;
        }
    }
}
