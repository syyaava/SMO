using SmoBL.Model;

namespace SmoBL.Controller
{
    /// <summary>
    /// Контроллер канала.
    /// </summary>
    public class ChannelController
    {
        public Channel Channel;

        public ChannelController()
        {
            Channel = new Channel();
        }

        /// <summary>
        /// Добавить заявку для обслуживания каналом.
        /// </summary>
        /// <param name="request">Заявка.</param>
        public void AddRequest(Request request)
        {
            Channel.CurRequest = request;
        }
    }
}
