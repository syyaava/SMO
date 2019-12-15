using SmoBL.Model;

namespace SmoBL.Controller
{
    /// <summary>
    /// Контроллер источника заявок.
    /// </summary>
    public class SourceController
    {
        /// <summary>
        /// Источник заявок.
        /// </summary>
        public Source Source;
        /// <summary>
        /// Состояние системы.
        /// </summary>
        public bool IsOnline { get; set; }

        public SourceController(bool isOnline, Source source)
        {
            IsOnline = isOnline;
            Source = source;
        }
        /// <summary>
        /// Создание заявки.
        /// </summary>
        /// <param name="processingTime">Время обслуживания заявки.</param>
        /// <returns>Новая заявка.</returns>
        public Request SpawnRequest(float processingTime)
        {
            return new Request(processingTime);
        }
    }
}
