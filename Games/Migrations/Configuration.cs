namespace Games.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Games.Models.GameDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Games.Models.GameDBContext context)
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

            // Seed Data
            context.Games.AddOrUpdate(i => i.Title,
                new Game
                {
                    Title = "Final Fantasy",
                    Platform = "NES",
                    Price = 20
                },
                new Game
                {
                    Title = "Final Fantasy II",
                    Platform = "SNES",
                    Price = 50
                },
                new Game
                {
                    Title = "Final Fantasy III",
                    Platform = "NES",
                    Price = 60
                },
                new Game
                {
                    Title = "Contra",
                    Platform = "NES",
                    Price = 30
                },
                new Game
                {
                    Title = "Super Contra",
                    Platform = "NES",
                    Price = 25
                },
                 new Game
                 {
                     Title = "Contra III",
                     Platform = "SNES",
                     Price = 45
                 }
            );
        }
    }
}
