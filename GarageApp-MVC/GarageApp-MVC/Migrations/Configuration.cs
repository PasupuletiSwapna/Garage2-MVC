namespace GarageApp_MVC.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GarageApp_MVC.DataAccessLayer.RegisterContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GarageApp_MVC.DataAccessLayer.RegisterContext context)
        {
            context.Vehicletypes.AddOrUpdate(v => v.VType,
                new VehicleType() { VType = "Auto" },
                new VehicleType() { VType = "Bus" },
                new VehicleType() { VType = "Bike" },
                new VehicleType() { VType = "Car" },
                new VehicleType() { VType = "Truck" }
                );

        }
    }
}
