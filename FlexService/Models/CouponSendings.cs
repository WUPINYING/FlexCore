﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexService.Models
{
    public partial class CouponSendings
    {
        public int SendingId { get; set; }
        public int FkCouponId { get; set; }
        public int? FkMemberId { get; set; }
        public DateTime SentDate { get; set; }
        public bool RedemptionStatus { get; set; }
        public DateTime? RedeemedDate { get; set; }

        public virtual Coupons FkCoupon { get; set; }
        public virtual Members FkMember { get; set; }
    }
}