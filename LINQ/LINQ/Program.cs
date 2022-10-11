using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static List<Student> GetStudents() {
            var students = new List<Student>(); 
            for (int i = 1; i <= 100; i++) {
                students.Add(new Student() { 
                    Id = i,
                    Name = "Student "+i
                });
            }
            return students;
        }
        
        static void Main(string[] args)
        {
            var marks = new int[] { 45, 43, 23, 12, 56, 78, 98, 99, 97, 56, 76, 87, 78, 95 };


            var passed = (from mark in marks
                         where mark >= 50
                         select mark).ToList();
            
            var students = GetStudents();

            var idLast = (from st in students
                          where st.Id >= 90
                          select st).ToList();
            var idMiddle = (from s in students
                            where s.Id >=30 && s.Id <= 50
                            select s).ToList();
            /*var passed = new int[marks.Length];
            var count_pass = 0;
            foreach (int i in marks) { 
                if(i >= 50)
                {
                    passed[count_pass++] = i;
                }
            }*/
        }
    }
}
