using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestLOLApp.DAL;

namespace TestLOLApp.Models
{
    public class ChampionStatsDTO
    {
        public int id { get; set;}
        public AggregatedStatsDTO stats { get; set; }

        public static string GetChampionName(int id)
        {
            Context db = new Context();
            var champ = db.Champions.Where(m => m.Championid.Equals(id)).FirstOrDefault();
            if (champ != null)
            {
                return champ.key;
            }
            else
            {
                return "";
            }
        }

    }

}