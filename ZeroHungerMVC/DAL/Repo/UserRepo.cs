using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class UserRepo : IRepo<User, string>
    {
        public void Add(User obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public void Edit(User obj)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            var db = new ZeroHungerEntities();
            return db.Users.ToList();
        }

        public User Get(string uname)
        {
            var db = new ZeroHungerEntities();
            return db.Users.FirstOrDefault(x => x.Uname.Equals(uname));
        }
    }
}
