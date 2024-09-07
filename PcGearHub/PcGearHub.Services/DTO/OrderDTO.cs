using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Services.DTO
{

    public class OrderDTO
    {
        public int OrderId { get; set; }

        public string OrderStatus { get; set; }
        public decimal TotalAmount { get; set; }
        // Diğer sipariş detayları
    }
}
