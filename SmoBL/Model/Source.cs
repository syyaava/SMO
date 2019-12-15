namespace SmoBL.Model
{
    /// <summary>
    /// Источник заявок.
    /// </summary>
    public class Source
    {
        /// <summary>
        /// Интервал появления заявок.
        /// </summary>
        public float SpawnDelay { get; set; }

        public Source(float spawnDelay)
        {
            SpawnDelay = spawnDelay;
        }
    }
}
