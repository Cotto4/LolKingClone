using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLOLApp.Models
{
    public class Player
    {
        public string matchHistoryUri { get; set; }
        public int profileIcon { get; set; }
        public long summonerId { get; set; }
        public string summonerName { get; set; }
    }
}