using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageApp_MVC.Models
{
    public class VehicleType
    {
       // [Key]
        public int VehicleTypeId { get; set; }
        public string VType { get; set; }

        public virtual ICollection<ParkedVehicle> Parkedvehicles { get; set; }
    }
}