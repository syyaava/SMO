using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoBL.Model
{
    public class Channel
    {
        public Request CurRequest { get; set; }
        public float Timer { get; set; }

        public Channel()
        {
            CurRequest = null;
            Timer = 0;
        }
    }
}
