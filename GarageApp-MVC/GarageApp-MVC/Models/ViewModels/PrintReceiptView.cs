﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarageApp_MVC.Models.ViewModels
{
    public class PrintReceiptView
    {

      

        [DisplayName("Vehicle ID")]
        public int ID { get; set; }
        [DisplayName("Registration Number")]
        public string RegNum { get; set; }
        public string VehicleType { get; set; }
        [DisplayName("CheckIn")]
        public DateTime ParkingTime { get; set; }
     
        public DateTime CheckOut { get; set; }

        //[DisplayFormat(DataFormatString = "{0:C0}")]
        //public int HourlyPrice { get; set; }

        [DisplayFormat(DataFormatString ="{0:%d} day(s) {0:hh\\:mm\\:ss}")]
        public TimeSpan TotalTime { get; set; }


     



        public PrintReceiptView()
        {
           
        }


        public PrintReceiptView(ParkedVehicle parvehicle)
        {

            ID = parvehicle.Id;
            RegNum = parvehicle.RegNum;
            VehicleType = parvehicle.VehicleType.ToString();
            ParkingTime= parvehicle.ParkingTime;
            CheckOut = DateTime.Now;
            //HourlyPrice = 40;
            TotalTime= CheckOut - ParkingTime;
            //double TotalPrice = 20*(TotalTime.TotalMinutes);


        }
    }
}

