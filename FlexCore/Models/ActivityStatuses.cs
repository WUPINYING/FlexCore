﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models
{
    public partial class ActivityStatuses
    {
        public ActivityStatuses()
        {
            Activities = new HashSet<Activities>();
        }

        public int ActivityStatusId { get; set; }
        public string ActivityStatusDescription { get; set; }

        public virtual ICollection<Activities> Activities { get; set; }
    }
}