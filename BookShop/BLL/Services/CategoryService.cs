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
    public class CategoryService
    {
        public static List<CategoryDTO> Get() {
            var data = DataAccessFactory.CategoryDataAccess().Get();
            var config = new MapperConfiguration(c => {
                c.CreateMap<Category, CategoryDTO>();
                c.CreateMap<Book, BookDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CategoryDTO>>(data);
        }
        public static CategoryDTO Get(int id)
        {
            var data = DataAccessFactory.CategoryDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Category, CategoryDTO>();
                c.CreateMap<Book, BookDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<CategoryDTO>(data);
        }

        public static CategoryBookDTO GetwithBooks(int id)
        {
            var data = DataAccessFactory.CategoryDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Category, CategoryBookDTO>();
                c.CreateMap<Book, BookDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<CategoryBookDTO>(data);
        }
        public static CategoryDTO Add(CategoryDTO data)
        {
            var config = new MapperConfiguration(c => {
                c.CreateMap<CategoryDTO, Category>();
                c.CreateMap<Category, CategoryDTO>();
            });
            var mapper = new Mapper(config);
            var dbobj = mapper.Map<Category>(data);
            var ret =DataAccessFactory.CategoryDataAccess().Add(dbobj);
            return mapper.Map<CategoryDTO>(ret);

        }
    }
}
