using BLL.DTOs;
using DAL.EF;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CollectionReqService
    {
        public static List<CollectionReqDTO> Get() {
            var data = new CollectionRepo().Get();
            var list = new List<CollectionReqDTO>();
            foreach (var item in data)
            {
                list.Add(Convert(item));
            }
            return list;    
        }

        public static CollectionReqDTO Get(int id)
        {
            var data = new CollectionRepo().Get(id);
            return Convert(data);
        }
        public static void Add(CollectionReqDTO col) {
            var data = Convert(col);
            new CollectionRepo().Add(data);
        }
        public static void Edit(CollectionReqDTO col) {
            var data = Convert(col);
            new CollectionRepo().Edit(data);
        }
        public static List<CollectionReqDTO> GetByEmp(string empname) {
            var data = new CollectionRepo().Get().
                Where( cr => cr.AssignedEmp != null && cr.AssignedEmp.Equals(empname)).ToList();
            var list = new List<CollectionReqDTO>();
            foreach (var item in data)
            {
                list.Add(Convert(item));
            }
            return list;

        }
        static CollectionReqDTO Convert(CollectionReq col) {
            return new CollectionReqDTO() { 
                Id = col.Id,
                AssignedEmp = col.AssignedEmp,
                Status  = col.Status,
                PrevTime = col.PrevTime,
                Description = col.Description,
            };
        }
        static CollectionReq Convert(CollectionReqDTO col) {
            return new CollectionReq() {
                Id = col.Id,
                AssignedEmp = col.AssignedEmp,
                Status = col.Status,
                PrevTime = col.PrevTime,
                Description = col.Description,
            };
        }
    }
}
