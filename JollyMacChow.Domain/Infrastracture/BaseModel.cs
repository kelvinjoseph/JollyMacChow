﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JollyMacChow.Domain.Infrastracture
{
    public class BaseModel
    {
        public BaseModel()
        {
            this.Timestamp = DateTime.UtcNow;
        }

        public Guid? Id { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
