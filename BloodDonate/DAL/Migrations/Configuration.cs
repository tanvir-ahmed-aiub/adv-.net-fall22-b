namespace DAL.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using DAL.EFCodeFirst.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<DAL.EFCodeFirst.Models.BloodDonateEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DAL.EFCodeFirst.Models.BloodDonateEntities context)
        {

            List<Group> groups = new List<Group>();
            for (int i = 0; i < 100; i++) {
                groups.Add(new Group() { 
                    Id = i,
                    Name = Guid.NewGuid().ToString().Substring(0,7)
                });
            }
            context.Groups.AddOrUpdate(groups.ToArray());
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
