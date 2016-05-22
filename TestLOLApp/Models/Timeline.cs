using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLOLApp.Models
{
    public class Timeline
    {
        public long frameInterval { get; set; }
        public List<Frame> frames { get; set; }
    }
}