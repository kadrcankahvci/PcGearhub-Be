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
    public class PaymentService : BaseService<Payment>, IPaymentService
    {
        public PaymentService(IPaymentRepository repository) : base(repository)
        {
        }
    }
}
