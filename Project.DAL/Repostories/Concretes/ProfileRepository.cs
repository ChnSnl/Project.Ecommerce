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
    public class ProfileRepository : BaseRepository<AppUserProfile>, IProfileRepository
    {
        public ProfileRepository(MyContext db):base(db)
        {

        }
    }
}
