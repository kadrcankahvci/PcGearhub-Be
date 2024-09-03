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
    public class AddressService : BaseService<Address>, IAddressService
    {
        public AddressService(IRepository<Address> repository) : base(repository)
        {
        }
    }
}
