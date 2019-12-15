using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoBL.Model
{
    public class Source
    {
        public float SpawnDelay { get; set; }

        public Source(float spawnDelay)
        {
            SpawnDelay = spawnDelay;
        }
    }
}
