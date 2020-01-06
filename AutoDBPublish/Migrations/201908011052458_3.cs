namespace AutoDBPublish.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "AddressId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "AddressId");
            AddForeignKey("dbo.Employees", "AddressId", "dbo.Addresses", "AddressId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "AddressId", "dbo.Addresses");
            DropIndex("dbo.Employees", new[] { "AddressId" });
            DropColumn("dbo.Employees", "AddressId");
        }
    }
}
