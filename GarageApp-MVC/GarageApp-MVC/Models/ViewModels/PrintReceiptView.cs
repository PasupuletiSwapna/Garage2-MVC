using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageApp_MVC.Models.ViewModels
{
    public class PrintReceiptView
    {
        public string RegNum { get; set; }
        public string VehicleType { get; set; }
        public DateTime ParkingTime { get; set; }
        [DisplayFormat(DataFormatString = "{0:C0}")]
        public float? Price { get; set; }

        public PrintReceiptView()
        { }


        public PrintReceiptView(ParkedVehicle parvehicle)
        {

            RegNum = parvehicle.RegNum;
            VehicleType = parvehicle.VehicleType.ToString();
            ParkingTime = parvehicle.ParkingTime;
            //Price = parvehicle.Price;



        }
    }
}