using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLOLApp.Models
{
    public class ChampionIDMap : IEnumerable<ChampionIDMap>
    {
        public int id { get; set; }
        public int Championid { get; set; }
        public string key { get; set; }
        private List<ChampionIDMap> championList;

        IEnumerator<ChampionIDMap> IEnumerable<ChampionIDMap>.GetEnumerator()
        {
            return championList.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            return championList.GetEnumerator();
        }
    }
}