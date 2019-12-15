using SmoBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoBL.Controller
{
    public class ChannelController
    {
        public Channel Channel;

        public ChannelController()
        {
            Channel = new Channel();
        }

        public void AddRequest(Request request)
        {
            Channel.CurRequest = request;
        }
    }
}
