﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexService.Models
{
    public partial class PointHistories
    {
        public int PointHistoryId { get; set; }
        public bool GetOrDeduct { get; set; }
        public int UsageAmount { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int? FkMemberId { get; set; }
        public int? FkOrderId { get; set; }
        public int? FkTypeId { get; set; }
        public int? FkMemberPointsId { get; set; }

        public virtual Members FkMember { get; set; }
        public virtual MemberPoints FkMemberPoints { get; set; }
        public virtual Orders FkOrder { get; set; }
        public virtual Type FkType { get; set; }
    }
}