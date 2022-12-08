using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EFCodeFirst.Models
{
    internal class BloodDonateEntities : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
