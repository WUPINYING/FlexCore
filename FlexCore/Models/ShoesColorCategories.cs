﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models
{
    public partial class ShoesColorCategories
    {
        public ShoesColorCategories()
        {
            CustomizedShoesPo = new HashSet<CustomizedShoesPo>();
            ShoesGroups = new HashSet<ShoesGroups>();
        }

        public int ShoesColorId { get; set; }
        public string ColorName { get; set; }
        public string ColorCode { get; set; }

        public virtual ICollection<CustomizedShoesPo> CustomizedShoesPo { get; set; }
        public virtual ICollection<ShoesGroups> ShoesGroups { get; set; }
    }
}