using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace GarageApp_MVC.Models
{
    public class ParkedVehicle
    {


        public int Id { get; set; }


      

        [Required]
        [StringLength(7, MinimumLength = 6, ErrorMessage = "Enter Proper RegNo with min 6charaters")]
        [Display(Name = "Registration Number")]
        public string RegNum { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special characters  & Numbers should not be entered")]
        public string Color { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special characters  & Numbers should not be entered")]
        public string Brand { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special characters  & Numbers should not be entered")]
        public string Model { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid Number")]
        [DisplayName("Number Of Wheels")]
        public int? NoOfWheels { get; set; }
        public int SeatCapacity { get; set; }

        [DisplayName("CheckIn")]
        [Column(TypeName = "datetime2")]
        public DateTime ParkingTime { get; set; }
        //public DateTime CheckOut { get; set; } 

        public int MemberId { get; set; }
        public int VehicleTypeId { get; set; }

        //[ForeignKey("MemberId")]
        public virtual Member Member { get; set; }
        //[ForeignKey("VehicleTypeId")]
        public virtual VehicleType VehicleType { get; set; }



        public ParkedVehicle()
        {

            ParkingTime = DateTime.Now;

        }

        //}
        //public enum Type
        //    {
        //        Car, Bus,Truck, Auto

        //    }

    }
}