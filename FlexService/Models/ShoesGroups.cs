﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexService.Models
{
    public partial class ShoesGroups
    {
        public int ShoesGroupId { get; set; }
        public int FkShoesMainId { get; set; }
        public int FkOptionId { get; set; }
        public int FkMaterialId { get; set; }
        public int FkShoesColorId { get; set; }
        public string Remark { get; set; }

        public virtual CustomizedMaterials FkMaterial { get; set; }
        public virtual ShoesChooses FkOption { get; set; }
        public virtual ShoesColorCategories FkShoesColor { get; set; }
        public virtual CustomizedShoesPo FkShoesMain { get; set; }
    }
}