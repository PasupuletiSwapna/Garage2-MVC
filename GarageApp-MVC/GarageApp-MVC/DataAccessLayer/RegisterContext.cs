using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace GarageApp_MVC.DataAccessLayer
{
    public class RegisterContext:DbContext
    {
        public RegisterContext():base("Garage-2")
        { }

        public DbSet<Models.ParkedVehicle> Vehicles { get; set; }

        public System.Data.Entity.DbSet<GarageApp_MVC.Models.ViewModels.PrintReceiptView> PrintReceiptViews { get; set; }
    }
}