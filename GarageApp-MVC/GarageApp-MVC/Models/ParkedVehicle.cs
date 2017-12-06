using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.ComponentModel;

namespace GarageApp_MVC.Models
{
    public class ParkedVehicle
    {

        public int Id { get; set; }
        public Type VehicleType { get; set; }
        public int RegNum { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        [DisplayName("No. Of Wheels")]
        public int NoOfWheels { get; set; }
        public int SeatCapacity { get; set; }
        public DateTime ParkingTime { get; set; }
        public string Search { get; set; }


        public ParkedVehicle()
        {

            ParkingTime = DateTime.Now;

        }
        
    }
    public enum Type
        {
            Car, Bus,Truck, Auto

        }

    
}