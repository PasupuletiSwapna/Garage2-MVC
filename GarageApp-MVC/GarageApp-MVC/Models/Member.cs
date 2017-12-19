using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarageApp_MVC.Models
{
    public class Member
    {
        public int Id { get; set; }
        [Required]
        public int MemberId { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z'' ']+$", ErrorMessage = "Special characters  & Numbers should not be entered")]
        public string OwnerName { get; set; }
        public string email { get; set; }
       
        [Required]
        [DisplayName("Phone No")]
        [RegularExpression(@"^[0-9'' ']+$", ErrorMessage = "Only Whole Numbers are Allowed")]
        public string mobile { get; set; }

        public virtual ICollection<ParkedVehicle> ParkedVehicles { get; set; }
    }
}