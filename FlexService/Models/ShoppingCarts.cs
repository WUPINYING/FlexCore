﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexService.Models
{
    public partial class ShoppingCarts
    {
        public int CartId { get; set; }
        public int FkMemberId { get; set; }

        public virtual Members FkMember { get; set; }
        public virtual CartItems CartItems { get; set; }
    }
}