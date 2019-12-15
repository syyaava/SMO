using SmoBL.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoBL.Model
{
    public class QueueingSystem
    {
        public ChannelController[] Channel { get; set; }
        public int CountChannel { get; set; }
        public List<Request> Queue { get; set; }
        public int QueueCapacity { get; set; }

        public QueueingSystem(int countChannel, int queueCapacity)
        {
            CountChannel = countChannel;
            QueueCapacity = queueCapacity;
            Channel = new ChannelController[CountChannel];
            FillChannel();
            Queue = new List<Request>();
        }

        private void FillChannel()
        {
            for (var i = 0; CountChannel > i; i++)
            {
                Channel[i] = new ChannelController();
            }
        }
    }
}
