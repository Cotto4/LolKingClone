using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestLOLApp.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TestLOLApp.DAL
{
    public class Context : DbContext
    {
        public DbSet<ChampionIDMap> Champions { get; set; }
    }
}