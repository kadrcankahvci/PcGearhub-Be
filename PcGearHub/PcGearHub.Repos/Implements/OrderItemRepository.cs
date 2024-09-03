﻿using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Repos.Implements
{
    public class OrderItemRepository : BaseRepository<OrderItem>, IOrderItemRepository
    {
        public OrderItemRepository(DemodbContext context) : base(context)
        {
        }
    }
}
