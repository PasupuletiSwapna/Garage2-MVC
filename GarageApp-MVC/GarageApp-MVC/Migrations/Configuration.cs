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
            context.Vehicles.AddOrUpdate(n => n.RegNum,
                                              new ParkedVehicle()
                                              {
                                                  RegNum = "C101",
                                                  VehicleType = Models.Type.Car,
                                                  Color = "Blue",
                                                  Brand = "Volksvagen",
                                                  Model = "A20",
                                                  NoOfWheels = 4,
                                                  SeatCapacity = 5

                                              },

                                                 new ParkedVehicle()
                                                 {
                                                     RegNum = "C102",
                                                     VehicleType = Models.Type.Car,
                                                     Color = "Red",
                                                     Brand = "BMW",
                                                     Model = "S2017",
                                                     NoOfWheels = 4,
                                                     SeatCapacity = 5

                                                 },

                                                   new ParkedVehicle()
                                                   {
                                                       RegNum = "A201",
                                                       VehicleType = Models.Type.Auto,
                                                       Color = "Orange",
                                                       Brand = "Hyonda",
                                                       Model = "Aws01",
                                                       NoOfWheels = 3,
                                                       SeatCapacity = 4

                                                   },
                                                     new ParkedVehicle()
                                                     {
                                                         RegNum = "A202",
                                                         VehicleType = Models.Type.Auto,
                                                         Color = "Orange",
                                                         Brand = "Hyonda",
                                                         Model = "Aws01",
                                                         NoOfWheels = 3,
                                                         SeatCapacity = 4

                                                     },
                                                    
                                                    

                                                     new ParkedVehicle()
                                                     {
                                                         RegNum = "T301",
                                                         VehicleType = Models.Type.Truck,
                                                         Color = "White",
                                                         Brand = "Swift",
                                                         Model = "V10",
                                                         NoOfWheels = 4,
                                                         SeatCapacity = 5

                                                     },


                                                       new ParkedVehicle()
                                                       {
                                                           RegNum = "C103",
                                                           VehicleType = Models.Type.Car,
                                                           Color = "Yellow",
                                                           Brand = "Toyota",
                                                           Model = "C01",
                                                           NoOfWheels = 6,
                                                           SeatCapacity = 4

                                                       },

                                                         new ParkedVehicle()
                                                         {
                                                             RegNum = "T302",
                                                             VehicleType = Models.Type.Truck,
                                                             Color = "Peach",
                                                             Brand = "TVS",
                                                             Model = "D02",
                                                             NoOfWheels = 6,
                                                             SeatCapacity = 4

                                                         },

                                                           new ParkedVehicle()
                                                           {
                                                               RegNum = "B401",
                                                               VehicleType = Models.Type.Bus,
                                                               Color = "Brown",
                                                               Brand = "Volvo",
                                                               Model = "AZ",
                                                               NoOfWheels = 10,
                                                               SeatCapacity = 25

                                                           },

                                                            new ParkedVehicle()
                                                            {
                                                                RegNum = "B402",
                                                                VehicleType = Models.Type.Bus,
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
