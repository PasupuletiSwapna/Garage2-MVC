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
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            context.Vehicletypes.AddOrUpdate(v => v.VType,
                 new VehicleType() { VType = "Auto" },
                 new VehicleType() { VType = "Bus" },
                 new VehicleType() { VType = "Bike" },
                 new VehicleType() { VType = "Car" },
                 new VehicleType() { VType = "Truck" }
                 );

            context.SaveChanges();

            context.Members.AddOrUpdate(v => v.mobile,
                new Member() { OwnerName = "Scott S", email = "sc_t@gmail.com", mobile = "0721987432" },
                new Member() { OwnerName = "Nile G", email = "Nile@hotmail.com", mobile = "072109001" });



            context.SaveChanges();

            int i = 1;
            foreach (Models.Member c in context.Members)
            {

                context.Vehicles.AddOrUpdate(v => v.RegNum,
                   new ParkedVehicle()
                   {

                       RegNum = "AQR101",
                       Color = "Orange",
                       Brand = "Hyonda",
                       Model = "Aws",
                       NoOfWheels = 3,
                       SeatCapacity = 4,
                       ParkingTime = DateTime.Now.AddMinutes(10),
                       MemberId = c.Id,
                     
                       VehicleType = context.Vehicletypes.ToList()[i++]
                   },


                new ParkedVehicle()
                {
                    RegNum = "AMN202",
                    Color = "Orange",
                    Brand = "Hyonda",
                    Model = "Aws",
                    NoOfWheels = 3,
                    SeatCapacity = 4,
                    ParkingTime = DateTime.Now.AddMinutes(10),
                    MemberId = c.Id,
                    VehicleType = context.Vehicletypes.ToList()[i++]
                }

              );




            }
            context.SaveChanges();






        }
    }
}
