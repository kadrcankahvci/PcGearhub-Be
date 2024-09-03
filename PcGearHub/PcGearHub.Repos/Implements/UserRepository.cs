using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Repos.Implements
{
    internal class UserRepository:BaseRepository<User>, IUserRepository    {
        public UserRepository(DemodbContext context) : base(context)
        {
            
        }
    }
}
