namespace YarnStache.Migrations

{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using YarnStache.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<YarnStache.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "YarnStache.Models.ApplicationDbContext";
        }

        protected override void Seed(YarnStache.Models.ApplicationDbContext context)
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
            context.Yarns.AddOrUpdate(
                y => y.ColorName,
                new Yarn { Id= Guid.NewGuid(), ColorFamily = "Yellow" , ColorName = "Sunshine", Brand = "I Love This Yarn", Weight = "Worsted", FiberType= "Acrylic", DyeLot= "1234", Quantity=1 },
                new Yarn { Id = Guid.NewGuid(), ColorFamily = "Yellow" , ColorName = "Submarine", Brand = "Beatles", Weight = "Light", FiberType = "Cotton", DyeLot = "4321", Quantity = 2 }
                );
        }
    }
}
