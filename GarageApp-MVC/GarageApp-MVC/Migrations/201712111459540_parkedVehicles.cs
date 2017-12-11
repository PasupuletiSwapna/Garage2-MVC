namespace GarageApp_MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class parkedVehicles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PrintReceiptViews",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RegNum = c.String(),
                        VehicleType = c.String(),
                        ParkingTime = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                        TotalTime = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ParkedVehicles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VehicleType = c.Int(nullable: false),
                        RegNum = c.String(),
                        Color = c.String(),
                        Brand = c.String(),
                        Model = c.String(),
                        NoOfWheels = c.Int(nullable: false),
                        SeatCapacity = c.Int(nullable: false),
                        ParkingTime = c.DateTime(nullable: false),
                        CheckOut = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ParkedVehicles");
            DropTable("dbo.PrintReceiptViews");
        }
    }
}
