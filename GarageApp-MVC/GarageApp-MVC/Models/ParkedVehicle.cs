using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageApp_MVC.Models
{
    public class ParkedVehicle
    {

        public int Id { get; set; }
        public string VehicleType { get; set; }
        public int RegNum { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int NoOfWheels { get; set; }
        public int SeatCapacity { get; set; }
        public DateTime ParkingTime { get; set; }


        public ParkedVehicle()
        {

            ParkingTime = DateTime.Now;

        }

    }
}