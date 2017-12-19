using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarageApp_MVC.Models.ViewModels
{
    public class Overview
    {

        public string OwnerName { get; set; }
        public string VType { get; set; }
        public string RegNum { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime ParkingTime { get; set; }

        //public Overview()
        //{ }

        //public Overview(ParkedVehicle pvehicle)
        //{
        //    RegNum = pvehicle.RegNum;
        //    VehicleType = pvehicle.VehicleType.ToString();

        //    Color = pvehicle.Color;
        //    ParkingTime = pvehicle.ParkingTime;


        //}





    }
}