using DAL.EFCodeFirst;
using DAL.EFCodeFirst.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class GroupRepoV2 : IRepo<Group, int, bool>
    {
        BloodDonateEntities db;
        internal GroupRepoV2() { 
        db = new BloodDonateEntities(); 
        }
        public bool Add(Group obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Group> Get()
        {
           return db.Groups.ToList();
        }

        public Group Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Group obj)
        {
            throw new NotImplementedException();
        }
    }
}
