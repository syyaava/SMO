using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmoBL.Model
{
    public class Statistic
    {
        /// <summary>
        /// Общее число заявок.
        /// </summary>
        public ulong CountAllRequest { get; set; }
        /// <summary>
        /// Число обслуженных заявок.
        /// </summary>
        public ulong CountServicedRequest { get; set; }
        /// <summary>
        /// Число не обслуженных заявок.
        /// </summary>
        public ulong CountNotServicedRequest { get; set; }
        /// <summary>
        /// Суммарное время всех заявок.
        /// </summary>
        public float TimeAllRequestInSys { get; set; }

        public RichTextBox StatisticText;

        public Statistic(RichTextBox richTextBox)
        {
            CountAllRequest = 0;
            CountServicedRequest = 0;
            CountNotServicedRequest = 0;
            TimeAllRequestInSys = 0;
            StatisticText = richTextBox;
        }

        public override string ToString()
        {
            return $"Общее число заявок: {CountAllRequest};\n" +
                   $"Число обслуженных заявок: {CountServicedRequest};\n" +
                   $"Число не обслуженных заявок: {CountNotServicedRequest};\n" +
                   $"Процент обслуженных заявок: {Math.Round((float)CountServicedRequest/CountAllRequest*100,3)}%;\n" +
                   $"Время обслуживания всех заявок: {TimeAllRequestInSys};\n" +
                   $"Среднее время обслуживания заявки: {Math.Round(TimeAllRequestInSys / CountServicedRequest, 3)}.";
        }
    }
}
