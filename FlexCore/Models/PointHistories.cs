﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models
{
    public partial class PointHistories
    {
        public int PointHistoryId { get; set; }
        public bool GetOrDeduct { get; set; }
        public int UsageAmount { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int? fk_MemberId { get; set; }
        public int? fk_OrderId { get; set; }
        public int? fk_TypeId { get; set; }
        public int? fk_MemberPointsId { get; set; }

        public virtual Members fk_Member { get; set; }
        public virtual MemberPoints fk_MemberPoints { get; set; }
        public virtual orders fk_Order { get; set; }
        public virtual Type fk_Type { get; set; }
    }
}