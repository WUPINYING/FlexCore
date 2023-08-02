﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexService.Models
{
    public partial class CustomizedShoesPo
    {
        public CustomizedShoesPo()
        {
            CustomizedOrders = new HashSet<CustomizedOrders>();
            ShoesGroups = new HashSet<ShoesGroups>();
            ShoesPictures = new HashSet<ShoesPictures>();
        }

        public int ShoesProductId { get; set; }
        public string ShoesName { get; set; }
        public string ShoesDescription { get; set; }
        public string ShoesOrigin { get; set; }
        public int ShoesUnitPrice { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? Status { get; set; }
        public int? FkShoesCategoryId { get; set; }
        public int? FkShoesColorId { get; set; }
        public DateTime DataCreateTime { get; set; }
        public DateTime DataEditTime { get; set; }

        public virtual ShoesCategories FkShoesCategory { get; set; }
        public virtual ShoesColorCategories FkShoesColor { get; set; }
        public virtual ICollection<CustomizedOrders> CustomizedOrders { get; set; }
        public virtual ICollection<ShoesGroups> ShoesGroups { get; set; }
        public virtual ICollection<ShoesPictures> ShoesPictures { get; set; }
    }
}