using PcGearHub.Data.DBModels;
using PcGearHub.Services.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.Interfaces
{
    public interface IAddressService:IBaseService<Address>
    {
         Task<Address> CreateAddressFromDto(AddressDTO addressDto);
    }
   
}
