using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Book, int, Book> BookDataAccess()
        {
            return new BookRepo();
        }
        public static IRepo<Category, int, Category> CategoryDataAccess()
        {
            return new CategoryRepo();
        }
    }
}
