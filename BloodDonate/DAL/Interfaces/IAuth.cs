﻿using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IAuth
    {
        User Authenticate (string username, string password);
        //
        //
        //
        //
        //
        //
        //
    }
}
