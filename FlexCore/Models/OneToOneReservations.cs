﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models
{
    public partial class OneToOneReservations
    {
        public int ReservationId { get; set; }
        public int fk_BookerId { get; set; }
        public DateTime ReservationStartTime { get; set; }
        public DateTime ReservationEndTime { get; set; }
        public int fk_BranchId { get; set; }
        public int fk_ReservationSpeakerId { get; set; }
        public int fk_ReservationStatusId { get; set; }
        public DateTime ReservationCreatedDate { get; set; }

        public virtual Members fk_Booker { get; set; }
        public virtual Branches fk_Branch { get; set; }
        public virtual Speakers fk_ReservationSpeaker { get; set; }
        public virtual ReservationStatuses fk_ReservationStatus { get; set; }
    }
}