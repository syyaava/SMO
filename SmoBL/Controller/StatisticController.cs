using SmoBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoBL.Controller
{
    public class StatisticController
    {
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

        public string GetStatistic()
        {
            return Statistic.ToString();
        }

        public void AddTimeInSystem(float time)
        {
            Statistic.TimeAllRequestInSys += time;
        }
    }
}
