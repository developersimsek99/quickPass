using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace quickPassProject.Models
{
    public class quickPassEntities : DbContext
    {
        public quickPassEntities() : base("quickPassDB") { }
        public DbSet<User> Users { get; set; }
        public DbSet<ReportUs> reportUs { get; set; }
    }
}