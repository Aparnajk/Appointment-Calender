using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebProject.Models
{
    public class CalendarContext : DbContext
    {
        public CalendarContext() : base()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CalendarContext>());
        }
        public System.Data.Entity.DbSet<WebProject.Models.Appointment> Appointments { get; set; }
    }
}