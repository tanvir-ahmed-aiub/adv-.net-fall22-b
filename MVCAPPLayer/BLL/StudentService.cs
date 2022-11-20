using BLL.DTOS;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StudentService
    {
        public static List<StudentDTO> GetStudents() {
            List<StudentDTO> students = new List<StudentDTO>();
            foreach (var st in StudentRepo.Get()) {
                students.Add(new StudentDTO() { 
                    Id = st.Id, Name = st.Name });
              
            }
            return students;
        
        }
    }
}
