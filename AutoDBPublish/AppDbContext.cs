using AutoDBPublish.Migrations;
using AutoDBPublish.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace AutoDBPublish
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("DefaultConnection")
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Address> Addresses { get; set; }


        public void UpdateDatabase()
        {
            var Migrator = new DbMigrator(new Migrations.Configuration() { TargetDatabase = new DbConnectionInfo(this.Database.Connection.ConnectionString, "System.Data.SqlClient") });
            IEnumerable<string> PendingMigrations = Migrator.GetPendingMigrations();
            foreach (var Migration in PendingMigrations)
                Migrator.Update(Migration);
            MasterData.Seed(this);
        }
    }
}