using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLOLApp.Models
{
    public class Frame
    {
        public List<Event> events { get; set; }
        public Dictionary<string, ParticipantFrame> participantFrames { get; set; }
        public long timestamp { get; set; }
    }
}