using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Members.dll.ViewModels
{
    public class RegisterVM
    {        
        public string?  Account { get; set; }
        public string? EncryptedPassword { get; set; }
    }
}
