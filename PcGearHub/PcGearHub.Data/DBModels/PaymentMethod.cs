﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace PcGearHub.Data.DBModels;

public partial class PaymentMethod
{
    public int PaymentMethodId { get; set; }

    public string MethodName { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string CreatedUser { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string UpdatedUser { get; set; }

    public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
}