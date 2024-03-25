using Microsoft.AspNetCore.Identity;
using Project.DAL.ContextClasses;
using Project.DAL.Repostories.Abstracts;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Repostories.Concretes
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        UserManager<AppUser> _userManager;

        public AppUserRepository(MyContext db, UserManager<AppUser> userManager) : base(db)
        {
            _userManager = userManager;
        }
        public async Task<bool> AddUser(AppUser user)
        {
            IdentityResult result = await _userManager.CreateAsync(user, user.PasswordHash);
            if (result.Succeeded) return true;
            return false;
        }
    }
}
