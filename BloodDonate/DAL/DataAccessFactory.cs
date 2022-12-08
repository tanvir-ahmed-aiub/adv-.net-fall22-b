using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<DAL.EFCodeFirst.Models.Group, int, bool> GroupDataAccess() {
            return new GroupRepoV2();
        }
        public static IRepo<Donor, int, Donor> DonorDataAccess() {
            return new DonorRepo();
        }
        public static IRepo<User, string, User> UserDataAccess() {
            return new UserRepo();
        }

        //examples
        public static IAuth AuthDataAccess() {
            return new UserRepo();
        }
        public static IRepo<Token, string, Token> TokenDataAccess() { 
            return new TokenRepo();
        }
    }
}
