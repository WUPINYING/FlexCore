﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexService.Models
{
    public partial class PointTradeIn
    {
        public int PointTradeInId { get; set; }
        public int FkMemberId { get; set; }
        public int? FkOrderId { get; set; }
        public string GiftThreshold { get; set; }
        public string GetPoints { get; set; }
        public string MaxGetPoints { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }

        public virtual Members FkMember { get; set; }
        public virtual Orders FkOrder { get; set; }
    }
}