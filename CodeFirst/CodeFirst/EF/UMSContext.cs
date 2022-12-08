using CodeFirst.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst.EF
{
    public class UMSContext : DbContext
    {
//        public UMSContext():base("sfdf") { }
        public DbSet<Student>  Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Department> Departments { get; set; }
    }
}