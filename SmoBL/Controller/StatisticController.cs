using SmoBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoBL.Controller
{
    public class StatisticController
    {
        private Statistic Statistic;

        public StatisticController()
        {
            Statistic = new Statistic();
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
    }
}
