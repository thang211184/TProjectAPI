namespace TProjectAPI.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TProjectAPI.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<TProjectAPI.Data.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TProjectAPI.Data.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            /*context.People.Add(new People()
            {
                FirstName = "Steven",
                LastName = "Pham",
                DOB = DateTime.Today
            });
            */
        }
    }
}
