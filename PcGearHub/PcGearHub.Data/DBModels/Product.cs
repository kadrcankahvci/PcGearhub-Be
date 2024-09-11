﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PcGearHub.Data.DBModels;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal Price { get; set; }

    public int StockQuantity { get; set; }

    public int? CategoryId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string CreatedUser { get; set; }

    public string UpdatedUser { get; set; }

    public virtual Category Category { get; set; }
    // Yeni eklenen sütun
    public string Image { get; set; } 

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

    public virtual ICollection<ProductReview> ProductReviews { get; set; } = new List<ProductReview>();
}