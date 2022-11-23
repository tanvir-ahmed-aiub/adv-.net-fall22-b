using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class UserRepo : IRepo<User, string, User>, IAuth
    {
        BloodDonateEntities db;
        internal UserRepo() {
            db = new BloodDonateEntities();
        }
        public User Add(User obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<User> Get()
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User obj)
        {
            throw new NotImplementedException();
        }
        public User Authenticate(string uname, string pass) {
            var user = db.Users.FirstOrDefault(
                    u=>
                    u.Username.Equals(uname) &&
                    u.Password.Equals(pass)
                );
            return user;
        }
    }
}
