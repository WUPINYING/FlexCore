﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models
{
    public partial class SalesCategories
    {
        public SalesCategories()
        {
            ProductCategories = new HashSet<ProductCategories>();
        }

        public int SalesCategoryId { get; set; }
        public string SalesCategoryName { get; set; }

        public virtual ICollection<ProductCategories> ProductCategories { get; set; }
    }
}