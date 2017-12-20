using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GarageApp_MVC.DataAccessLayer
{
    public class RegisterContext:DbContext
    {
        public RegisterContext():base("Garage-2.5")
        { }

        public DbSet<Models.ParkedVehicle> Vehicles { get; set; }
        public DbSet<Models.VehicleType> Vehicletypes { get; set; }
        public DbSet<Models.Member> Members { get; set; }

       
        public DbSet<GarageApp_MVC.Models.ViewModels.PrintReceiptView> PrintReceiptViews { get; set; }
    }
}