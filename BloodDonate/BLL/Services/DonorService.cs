using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DonorService
    {
        public static List<DonorDTO> Get() {
            var dbdata = DataAccessFactory.DonorDataAccess().Get();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Donor, DonorDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<List<DonorDTO>>(dbdata);
            return data;
        }
        public static DonorDTO Get(int id) { 
            var dbdata = DataAccessFactory.DonorDataAccess().Get(id);
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Donor, DonorDTO>());
            var mapper = new Mapper(config);
            var data = mapper.Map<DonorDTO>(dbdata);
            return data;

        }
        public static DonorDTO Add(DonorDTO dto) {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Donor, DonorDTO>();
                cfg.CreateMap<DonorDTO, Donor>();
                });
            var mapper = new Mapper(config);
            var data = mapper.Map<Donor>(dto);
            var result = DataAccessFactory.DonorDataAccess().Add(data);
            var redata = mapper.Map<DonorDTO>(result);
            return redata;
        }
    }
}
