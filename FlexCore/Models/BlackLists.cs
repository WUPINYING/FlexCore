﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace FlexCore.Models
{
    public partial class BlackLists
    {
        public BlackLists()
        {
            Members = new HashSet<Members>();
        }

        public int BlackListId { get; set; }
        public string Behavior { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual ICollection<Members> Members { get; set; }
    }
}