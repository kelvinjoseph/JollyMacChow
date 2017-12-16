﻿using JollyMacChow.Domain.Infrastracture;
using JollyMacChow.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JollyMacChow.Domain.Models
{
   public class User : BaseModel
    {
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        
    }
}
