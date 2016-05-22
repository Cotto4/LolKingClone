using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestLOLApp.Models
{
    public class ChampionModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public string Blurb { get; set; }
        public string Lore { get; set; }

    }
}