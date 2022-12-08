using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CategoryRepo : Repo, IRepo<Category, int, Category>
    {
        public Category Add(Category obj)
        {
            db.Categories.Add(obj);
            if(db.SaveChanges() > 0 ) return obj;
            return null;    
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> Get()
        {
            return db.Categories.ToList();
        }

        public Category Get(int id)
        {
            return db.Categories.Find(id);
        }

        public Category Update(Category obj)
        {
            throw new NotImplementedException();
        }
    }
}
