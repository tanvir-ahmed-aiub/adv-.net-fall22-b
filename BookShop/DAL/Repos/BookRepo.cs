using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BookRepo : Repo, IRepo<Book, int, Book>
    {
        public Book Add(Book obj)
        {
            db.Books.Add(obj);
            if (db.SaveChanges() > 0) {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Book> Get()
        {
            return db.Books.ToList();
        }

        public Book Get(int id)
        {
            return db.Books.Find(id);
        }

        public Book Update(Book obj)
        {
            throw new NotImplementedException();
        }
    }
}
