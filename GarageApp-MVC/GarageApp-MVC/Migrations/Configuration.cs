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
                                                  RegNum = "ART101",
                                                  VehicleType = Models.Type.Car,
                                                  Color = "Blue",
                                                  Brand = "Volksvagen",
                                                  Model = "A20",
                                                  NoOfWheels = 4,
                                                  SeatCapacity = 5

                                              },

                                                 new ParkedVehicle()
                                                 {
                                                     RegNum = "CQE102",
                                                     VehicleType = Models.Type.Car,
                                                     Color = "Red",
                                                     Brand = "BMW",
                                                     Model = "S2017",
                                                     NoOfWheels = 4,
                                                     SeatCapacity = 5

                                                 },

                                                   new ParkedVehicle()
                                                   {
                                                       RegNum = "BGR201",
                                                       VehicleType = Models.Type.Auto,
                                                       Color = "Orange",
                                                       Brand = "Hyonda",
                                                       Model = "Aws01",
                                                       NoOfWheels = 3,
                                                       SeatCapacity = 4

                                                   },

                                                     new ParkedVehicle()
                                                     {
                                                         RegNum = "ZOJ103",
                                                         VehicleType = Models.Type.Truck,
                                                         Color = "White",
                                                         Brand = "Swift",
                                                         Model = "V10",
                                                         NoOfWheels = 4,
                                                         SeatCapacity = 5

                                                     },


                                                       new ParkedVehicle()
                                                       {
                                                           RegNum = "NUI301",
                                                           VehicleType = Models.Type.Car,
                                                           Color = "Yellow",
                                                           Brand = "Toyota",
                                                           Model = "C01",
                                                           NoOfWheels = 6,
                                                           SeatCapacity = 4

                                                       },

                                                         new ParkedVehicle()
                                                         {
                                                             RegNum = "TYU302",
                                                             VehicleType = Models.Type.Truck,
                                                             Color = "Peach",
                                                             Brand = "TVS",
                                                             Model = "D02",
                                                             NoOfWheels = 6,
                                                             SeatCapacity = 4

                                                         },

                                                           new ParkedVehicle()
                                                           {
                                                               RegNum = "JD401H",
                                                               VehicleType = Models.Type.Bus,
                                                               Color = "Brown",
                                                               Brand = "Volvo",
                                                               Model = "AZ",
                                                               NoOfWheels = 10,
                                                               SeatCapacity = 25

                                                           },

                                                            new ParkedVehicle()
                                                            {
                                                                RegNum = "DER402",
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
