namespace SmoBL.Model
{
    /// <summary>
    /// Заявка.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// Время пребывания в системе.
        /// </summary>
        public float TimeInSystem { get; set; }
        /// <summary>
        /// Время обслуживания.
        /// </summary>
        public float ProcessingTime { get; set; }

        public Request(float processingTime)
        {
            TimeInSystem = 0;
            ProcessingTime = processingTime;
        }
    }
}
