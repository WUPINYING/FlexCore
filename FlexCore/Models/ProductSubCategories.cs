﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models
{
    public partial class ProductSubCategories
    {
        public ProductSubCategories()
        {
            Products = new HashSet<Products>();
        }

        public int ProductSubCategoryId { get; set; }
        public string ProductSubCategoryName { get; set; }
        public int fk_ProductCategoryId { get; set; }
        public string SubCategoryPath { get; set; }

        public virtual ProductCategories fk_ProductCategory { get; set; }
        public virtual ICollection<Products> Products { get; set; }
    }
}