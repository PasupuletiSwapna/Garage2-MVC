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

            context.Vehicles.AddOrUpdate(n => n.RegNum,
                                              new ParkedVehicle()
                                              {
                                                  RegNum = 101,
                                                  VehicleType = "Car",
                                                  Color = "Blue",
                                                  Brand = "Volksvagen",
                                                  Model = "A20",
                                                  NoOfWheels = 4,
                                                  SeatCapacity = 5

                                              },

                                                 new ParkedVehicle()
                                                 {
                                                     RegNum = 102,
                                                     VehicleType = "Car",
                                                     Color = "Red",
                                                     Brand = "BMW",
                                                     Model = "S2017",
                                                     NoOfWheels = 4,
                                                     SeatCapacity = 5

                                                 },

                                                   new ParkedVehicle()
                                                   {
                                                       RegNum = 201,
                                                       VehicleType = "Auto",
                                                       Color = "Orange",
                                                       Brand = "Hyonda",
                                                       Model = "Aws01",
                                                       NoOfWheels = 3,
                                                       SeatCapacity = 4

                                                   },

                                                     new ParkedVehicle()
                                                     {
                                                         RegNum = 103,
                                                         VehicleType = "Car",
                                                         Color = "White",
                                                         Brand = "Swift",
                                                         Model = "V10",
                                                         NoOfWheels = 4,
                                                         SeatCapacity = 5

                                                     },


                                                       new ParkedVehicle()
                                                       {
                                                           RegNum = 301,
                                                           VehicleType = "Truck",
                                                           Color = "Yellow",
                                                           Brand = "Toyota",
                                                           Model = "C01",
                                                           NoOfWheels = 6,
                                                           SeatCapacity = 4

                                                       },

                                                         new ParkedVehicle()
                                                         {
                                                             RegNum = 302,
                                                             VehicleType = "Truck",
                                                             Color = "Peach",
                                                             Brand = "TVS",
                                                             Model = "D02",
                                                             NoOfWheels = 6,
                                                             SeatCapacity = 4

                                                         },

                                                           new ParkedVehicle()
                                                           {
                                                               RegNum = 401,
                                                               VehicleType = "Bus",
                                                               Color = "Brown",
                                                               Brand = "Volvo",
                                                               Model = "AZ",
                                                               NoOfWheels = 10,
                                                               SeatCapacity = 25

                                                           },

                                                            new ParkedVehicle()
                                                            {
                                                                RegNum = 402,
                                                                VehicleType = "Bus",
                                                                Color = "Light Yellow",
                                                                Brand = "Hitex",
                                                                Model = "Q001",
                                                                NoOfWheels = 10,
                                                                SeatCapacity = 25

                                                            }
                                                            
                
                
                
                
                
                
                
                
                
                
                );
















        }
    }
}
