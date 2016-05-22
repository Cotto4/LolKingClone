using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLOLApp.Models
{
    public class RankedStatsDTO
    {
        public List<ChampionStatsDTO> champions { get; set; }
        public long modifyDate { get; set; }
        public long summonerId { get; set; }
    }
}