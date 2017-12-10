namespace GarageApp_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class overview : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ParkedVehicles", "VehicleType", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ParkedVehicles", "VehicleType", c => c.String());
        }
    }
}
