﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexService.Models
{
    public partial class ProductImgs
    {
        public int ProductImgId { get; set; }
        public string FkProductId { get; set; }
        public string ImgPath { get; set; }

        public virtual Products FkProduct { get; set; }
    }
}