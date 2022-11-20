using BLL.DTOs;
using DAL.EF;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static UserDTO Get(string uname) { 
            var dbuser = new UserRepo().Get(uname);
            if (dbuser != null) {
                var user = new UserDTO()
                {
                    Uname = dbuser.Uname,
                    Password = dbuser.Password,
                    Type = dbuser.Type,

                };
                return user;
            }
            return null;    
        }
        public static List<UserDTO> GetAllEmps() {
            var emps = new UserRepo().Get().Where(e => e.Type.Equals("Emp"));
            var data = new List<UserDTO>();
            foreach (var item in emps) {
                data.Add(Convert(item));
            }
            return data;
        }
        public static UserDTO Convert(User u) {
            return new UserDTO() {
                Id = u.Id,
                Uname = u.Uname,
                Password = u.Password,
                Type = u.Type
            };
        }
    }
}
