﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.DTO
{
    public class UserDetailDTO
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public List<AddressDTO> Addresses { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }
}
