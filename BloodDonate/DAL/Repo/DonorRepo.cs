using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    class DonorRepo : IRepo<Donor, int, Donor>
    {
        BloodDonateEntities db;
        internal DonorRepo() { 
            db = new BloodDonateEntities();
        }
        public Donor Add(Donor obj)
        {
            db.Donors.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(int id)
        {
            db.Donors.Remove(db.Donors.Find(id));
            return db.SaveChanges() > 0;
        }

        public List<Donor> Get()
        {
            return db.Donors.ToList();  
        }

        public Donor Get(int id)
        {
            return db.Donors.Find(id);
        }

        public bool Update(Donor obj)
        {
            var ext = db.Donors.Find(obj.Id);
            db.Entry(ext).CurrentValues.SetValues(obj);
            return db.SaveChanges() > 0;
        }
    }
}
