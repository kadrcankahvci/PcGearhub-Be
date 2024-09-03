using PcGearHub.Data.DBModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Repos.Interfaces
{


    public interface IPaymentMethodRepository : IRepository<PaymentMethod>
    {
        // PaymentMethod'a özel metotlar buraya eklenebilir
    }

}
