namespace AutoDBPublish.Migrations
{
    using AutoDBPublish.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AutoDBPublish.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AutoDBPublish.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            MasterData.Seed(context);
        }
    }

    public static class MasterData
    {
        public static void Seed(AutoDBPublish.AppDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Addresses.AddOrUpdate(new Address { AddressId = 1, AddressLine = "test", Country = "India", State = "Delhi" }); context.SaveChanges();
            context.Addresses.AddOrUpdate(new Address { AddressId = 2, AddressLine = "test", Country = "India", State = "Delhi1" }); context.SaveChanges();
        }
    }
}
