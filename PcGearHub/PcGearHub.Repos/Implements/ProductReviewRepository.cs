﻿using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PcGearHub.Repos.Interfaces.IProductReviewRepository;

namespace PcGearHub.Repos.Implements
{
    public class ProductReviewRepository : BaseRepository<ProductReview>,IProductReviewRepository {
        public ProductReviewRepository(DemodbContext context) : base(context)
        {
        }
    }
}