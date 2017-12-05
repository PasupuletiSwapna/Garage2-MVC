using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GarageApp_MVC.Models.ViewModels
{
    public class Overview
    {
        public int RegNum { get; set; }
        public string VehicleType { get; set; }
        public string Color { get; set; }
        public DateTime ParkingTime { get; set; }

        public Overview()
        { }

        public Overview(ParkedVehicle pvehicle)
        {
            RegNum = pvehicle.RegNum;
            VehicleType = pvehicle.VehicleType;
           
            Color = pvehicle.Color;
            ParkingTime = pvehicle.ParkingTime;


        }





    }
}