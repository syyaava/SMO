namespace SmoBL.Model
{
    /// <summary>
    /// Канал обслуживания
    /// </summary>
    public class Channel
    {
        /// <summary>
        /// Текущая заявка на обслуживании.
        /// </summary>
        public Request CurRequest { get; set; }
        /// <summary>
        /// Таймер для контроля времени обслуживания текущей заявки.
        /// </summary>
        public float Timer { get; set; }

        public Channel()
        {
            CurRequest = null;
            Timer = 0;
        }
    }
}
