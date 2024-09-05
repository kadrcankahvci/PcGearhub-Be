using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.DTO
{
    public class AddressDTO
    {
        public int?  AddressId { get; set; }



        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }

        public string Country { get; set; }
       public string AdressType { get; set; }
}
}