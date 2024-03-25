﻿using Project.BLL.Managers.Abstracts;
using Project.DAL.Repostories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Managers.Concretes
{
    public class ProfileManager : BaseManager<AppUserProfile>, IProfileManager
    {
        readonly IProfileRepository _proRep;

        public ProfileManager(IProfileRepository proRep):base(proRep)
        {
            _proRep = proRep;
        }
    }
}
