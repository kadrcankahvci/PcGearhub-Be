using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Implements;
using PcGearHub.Repos.Interfaces;
using PcGearHub.Services.DTO;
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
        public AddressService(IAddressRespository repository) : base(repository)
        {
        }
        public async Task<Address> CreateAddressFromDto(AddressDTO addressDto)
        {
            // AddressDTO'dan Address modelini oluşturun
            var address = new Address
            {
                Street = addressDto.Street,
                City = addressDto.City,
                State = addressDto.State,
                PostalCode = addressDto.PostalCode,
                Country = addressDto.Country,
                AdressType = addressDto.AdressType
            };

            // Address kaydını veritabanına ekleyin
            await _repository.Create(address);
            return address;
        }

    }
}
