using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoBL.Model
{
    public class Statistic
    {
        /// <summary>
        /// Общее число заявок.
        /// </summary>
        public long CountAllRequest { get; set; }
        /// <summary>
        /// Число обслуженных заявок.
        /// </summary>
        public long CountServicedRequest { get; set; }
        /// <summary>
        /// Число необслуженных заявок.
        /// </summary>
        public long CountNotServicedRequest { get; set; }
        /// <summary>
        /// Суммарное время всех заявок.
        /// </summary>
        public float TimeAllRequestInSys { get; set; }

        public Statistic()
        {
            CountAllRequest = 0;
            CountServicedRequest = 0;
            CountNotServicedRequest = 0;
            TimeAllRequestInSys = 0;
        }
    }
}
