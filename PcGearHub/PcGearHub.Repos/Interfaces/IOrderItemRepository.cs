using PcGearHub.Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Repos.Interfaces
{
   
    
        public interface IOrderItemRepository : IRepository<OrderItem>
        {
            // OrderItem'a özel metotlar buraya eklenebilir
        }
    
}
