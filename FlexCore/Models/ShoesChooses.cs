﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models
{
    public partial class ShoesChooses
    {
        public ShoesChooses()
        {
            ShoesGroups = new HashSet<ShoesGroups>();
        }

        public int OptionId { get; set; }
        public string OptinName { get; set; }

        public virtual ICollection<ShoesGroups> ShoesGroups { get; set; }
    }
}