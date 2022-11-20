using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CollectionRepo : IRepo<CollectionReq, int>
    {
        public void Add(CollectionReq obj)
        {
            var db = new ZeroHungerEntities();
            db.CollectionReqs.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CollectionReq obj)
        {
            var db = new ZeroHungerEntities();
            var ext = db.CollectionReqs.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            db.SaveChanges();

        }

        public List<CollectionReq> Get()
        {
            var db = new ZeroHungerEntities();
            return db.CollectionReqs.ToList();
        }

        public CollectionReq Get(int id)
        {
            var db = new ZeroHungerEntities();
            return db.CollectionReqs.FirstOrDefault(x => x.Id == id);   
        }
    }
}
