using PcGearHub.Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Repos.Implements
{
    public class CategoryRepository : BaseRepository<Category>
    {
        public CategoryRepository(DemodbContext context) : base(context)
        {
            
        }
    }
}
