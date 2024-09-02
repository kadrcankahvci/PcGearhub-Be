using PcGearHub.Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Repos.Implements
{
    internal class UserRepository:BaseRepository<User>    {
        public UserRepository(DemodbContext context) : base(context)
        {
            
        }
    }
}
