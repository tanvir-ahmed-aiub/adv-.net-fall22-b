using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StudentRepo
    {
        public static List<Student> Get() {
            /*List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++) { 
                students.Add(new Student() { 
                    Id = i+1,
                    Name = "Student  "+(i+1)
                });
            }*/
            var db = new UMSfall22_bEntities();
            return db.Students.ToList();
        }
        public static Student get(int id) {
            return null;
        }
    }
}
