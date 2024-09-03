using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Repos.Implements
{
    public class PaymentMethodRepository : BaseRepository<PaymentMethod>,IPaymentMethodRepository
    {
        public PaymentMethodRepository(DemodbContext context) : base(context)
        {
        }
    }
}