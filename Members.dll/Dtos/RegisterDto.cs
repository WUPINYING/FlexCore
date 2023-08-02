﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.dll.Dtos
{
    public class RegisterDto
    {       
       
        public string? Account { get; set; }

        public string? EncryptedPassword { get; set; }

        public string? Email { get; set; }

        public DateTime? Birthday { get; set; }

        public string? Mobile { get; set; }

        public string? Name { get; set; }

        public int? fk_LevelId { get; set; }

    }
}
