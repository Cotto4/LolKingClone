using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLOLApp.Models
{
    public class ParticipantFrame
    {
        public int currentGold { get; set; }
        public int dominionScore { get; set; }
        public int jungleMinionsKilled { get; set; }
        public int level { get; set; }
        public int minionsKilled { get; set; }
        public int participantId { get; set; }
        public Position position { get; set; }
        public int teamScore { get; set; }
        public int totalGold { get; set; }
        public int xp { get; set; }
    }
}