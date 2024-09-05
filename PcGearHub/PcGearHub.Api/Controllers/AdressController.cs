using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Services.DTO;
using PcGearHub.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PcGearHub.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AddressController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public AddressController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Address>>> GetAllAddresses()
        {
            var addresses = await _addressService.GetAll();
            return Ok(addresses);
        }

        [HttpGet("{id}")]
        public  IActionResult GetAddressById(int id)
        {
            var addressQuery =  _addressService.GetById(id);
            

            if (addressQuery == null)
            {
                return NotFound();
            }

            return Ok(addressQuery);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress([FromBody] AddressDTO addressDto)
        {
            if (addressDto == null)
            {
                return BadRequest("Address data cannot be null.");
            }

            // DTO'dan model oluşturma ve kaydetme işlemi
            var address = await _addressService.CreateAddressFromDto(addressDto);

            return CreatedAtAction(nameof(GetAddressById), new { id = address.AddressId }, address);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAddress(int id, [FromBody] Address address)
        {
            if (id != address.AddressId)
            {
                return BadRequest("ID mismatch");
            }

            var existingAddress = _addressService.GetById(id);
            if (existingAddress == null)
            {
                return NotFound();
            }

            await _addressService.Update(address);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAddress(int id)
        {
            var existingAddress = _addressService.GetById(id);
            if (existingAddress == null)
            {
                return NotFound();
            }

            await _addressService.Delete(id);
            return NoContent();
        }
    }
}
