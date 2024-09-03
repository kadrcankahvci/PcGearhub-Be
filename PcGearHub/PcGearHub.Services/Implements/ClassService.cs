using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Interfaces;
using PcGearHub.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.Implements
{
    public class ClassService : BaseService<Category>, ICategoryService
    {
        public ClassService(IRepository<Category> repository) : base(repository)
        {
        }
    }
}
