﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexService.Models
{
    public partial class OrderItems
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public int FkTypeId { get; set; }
        public int? PerPrice { get; set; }
        public int? Quantity { get; set; }
        public string DiscountName { get; set; }
        public int? Subtotal { get; set; }
        public int? DiscountSubtotal { get; set; }
        public string ItemsDescription { get; set; }

        public virtual Type FkType { get; set; }
        public virtual Orders Order { get; set; }
    }
}