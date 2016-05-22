namespace TestLOLApp.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestLOLApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TestLOLApp.DAL.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TestLOLApp.DAL.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var mappings = new List<ChampionIDMap>
            {
                new ChampionIDMap {Championid = 412, key = "Thresh" },
                new ChampionIDMap {Championid = 115, key = "Ziggs" },
                new ChampionIDMap {Championid = 432, key = "Bard" }
            };
            mappings.ForEach(m => context.Champions.AddOrUpdate(p => p.Championid, m));
            context.SaveChanges();


        }
    }
}
