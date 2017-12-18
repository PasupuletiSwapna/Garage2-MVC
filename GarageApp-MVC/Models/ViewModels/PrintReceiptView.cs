using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageApp_MVC.Models.ViewModels
{
    public class PrintReceiptView
    {

        private int price = 100;

        [DisplayName("Registration Number")]
        public string RegNum { get; set; }
        public string VehicleType { get; set; }
        [DisplayName("ParkingTime")]
        public DateTime CheckIn{ get; set; }
        [DisplayName("CheckOut Time")]
        public DateTime CheckOut{ get; set; }
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]

        public int Price { get; }

        [DisplayName("Total Parking Time")]

        public TimeSpan TotalTime => CheckOut - CheckIn;


        public PrintReceiptView()
        { }


        public PrintReceiptView(ParkedVehicle parvehicle)
        {

            RegNum = parvehicle.RegNum;
            VehicleType = parvehicle.VehicleType.ToString();
            CheckIn = (DateTime)parvehicle.CheckIn;
            CheckOut = DateTime.Now;
            



        }
    }
}