﻿using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repostories.Abstracts
{
    public interface IAppUserRepository:IRepository<AppUser>
    {
        Task<bool> AddUser(AppUser user);
    }
}
