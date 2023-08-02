﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexService.Models
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
            PointHistories = new HashSet<PointHistories>();
            PointTradeIn = new HashSet<PointTradeIn>();
        }

        public int Id { get; set; }
        public DateTime Ordertime { get; set; }
        public int FkMemberId { get; set; }
        public int TotalQuantity { get; set; }
        public int LogisticsCompanyId { get; set; }
        public int OrderStatusId { get; set; }
        public int PayMethodId { get; set; }
        public int PayStatusId { get; set; }
        public string CouponName { get; set; }
        public int? CouponDiscount { get; set; }
        public int? Freight { get; set; }
        public string Cellphone { get; set; }
        public string Receipt { get; set; }
        public string Receiver { get; set; }
        public string RecipientAddress { get; set; }
        public string OrderDescription { get; set; }
        public int TotalPrice { get; set; }
        public bool? Close { get; set; }
        public DateTime? CloseTime { get; set; }
        public int? FkTypeId { get; set; }

        public virtual Members FkMember { get; set; }
        public virtual Type FkType { get; set; }
        public virtual LogisticsCompanies LogisticsCompany { get; set; }
        public virtual OrderStatuses OrderStatus { get; set; }
        public virtual PayMethods PayMethod { get; set; }
        public virtual PayStatuses PayStatus { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
        public virtual ICollection<PointHistories> PointHistories { get; set; }
        public virtual ICollection<PointTradeIn> PointTradeIn { get; set; }
    }
}