namespace CodeFirst.Migrations
{
    using CodeFirst.EF.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.EF.UMSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirst.EF.UMSContext context)
        {
            List<Department> depts = new List<Department>();
            for (int i = 1; i <= 5; i++) {
                depts.Add(new Department() { 
                    DeptId = i,
                    Name = Guid.NewGuid().ToString().Substring(0,4)
                });
            }
            context.Departments.AddOrUpdate(depts.ToArray());

            List<Student> students = new List<Student>();
            Random random = new Random();
            for (int i = 1; i <= 10000; i++) {
                students.Add(new Student() { 
                    Id = i,
                    Name  = Guid.NewGuid().ToString().Substring(0,10),
                    DeptId = random.Next(1,6)
                });
            }
            context.Students.AddOrUpdate(students.ToArray());

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
