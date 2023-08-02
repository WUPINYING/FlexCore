﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexService.Models
{
    public partial class OneToOneReservations
    {
        public int ReservationId { get; set; }
        public int FkBookerId { get; set; }
        public DateTime ReservationStartTime { get; set; }
        public DateTime ReservationEndTime { get; set; }
        public int FkBranchId { get; set; }
        public int FkReservationSpeakerId { get; set; }
        public int FkReservationStatusId { get; set; }
        public DateTime ReservationCreatedDate { get; set; }

        public virtual Members FkBooker { get; set; }
        public virtual Branches FkBranch { get; set; }
        public virtual Speakers FkReservationSpeaker { get; set; }
        public virtual ReservationStatuses FkReservationStatus { get; set; }
    }
}