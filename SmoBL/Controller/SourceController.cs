using SmoBL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoBL.Controller
{
    public class SourceController
    {
        public Source Source;
        public bool IsOnline { get; set; }

        public SourceController(bool isOnline, Source source)
        {
            IsOnline = isOnline;
            Source = source;
        }

        public Request SpawnRequest(float processingTime)
        {
            return new Request(processingTime);
        }
    }
}
