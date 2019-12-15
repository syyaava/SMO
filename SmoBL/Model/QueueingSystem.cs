using SmoBL.Controller;
using System.Collections.Generic;

namespace SmoBL.Model
{
    /// <summary>
    /// СМО.
    /// </summary>
    public class QueueingSystem
    {
        /// <summary>
        /// Каналы обслуживания.
        /// </summary>
        public ChannelController[] Channel { get; set; }
        /// <summary>
        /// Количество каналов обслуживания.
        /// </summary>
        public int CountChannel { get; set; }
        /// <summary>
        /// Очередь заявок.
        /// </summary>
        public List<Request> Queue { get; set; }
        /// <summary>
        /// Длина очереди.
        /// </summary>
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
