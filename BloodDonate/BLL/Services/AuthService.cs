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
    public class AuthService
    {
        public static TokenDTO Authenticate(string username, string password) { 
            var user = DataAccessFactory.AuthDataAccess().Authenticate(username, password);
            if (user != null) { 
                Token t = new Token();
                t.CreationTime = DateTime.Now;
                t.Username = user.Username;
                t.ExpirationTime = null;
                t.TKey = Guid.NewGuid().ToString();
                var rt =DataAccessFactory.TokenDataAccess().Add(t);
                if (rt != null) {
                    var config = new MapperConfiguration(cfg => {
                        cfg.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(config);
                    var data = mapper.Map<TokenDTO>(rt);
                    return data;
                }
            }
            return null;
        }
        public static bool TokenValidity(string tkey) { 
            var token = DataAccessFactory.TokenDataAccess().Get(tkey);
            if (token != null && token.ExpirationTime == null) {
                return true;   
            }
            return false;
        }
    }
}
