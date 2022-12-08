using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BookService
    {
        public static List<BookDTO> Get()
        {
            var data = DataAccessFactory.BookDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Book, BookDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<BookDTO>>(data);
        }
        public static BookDTO Get(int id)
        {
            var data = DataAccessFactory.BookDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Book, BookDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<BookDTO>(data);
        }
        public static BookDTO Add(BookDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<BookDTO, Book>();
                c.CreateMap<Book, BookDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Book>(data);
            var ret = DataAccessFactory.BookDataAccess().Add(dbobj);
            return mapper.Map<BookDTO>(ret);

        }
    }
}
