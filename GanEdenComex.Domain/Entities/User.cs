﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GanEdenComex.Domain.Entities
{
    public class User: BaseEntity
    {
        public string? Name { get; set; }

        public string? Email { get; set; }
        [JsonIgnore]
        public string? Password { get; set; }
    }
}
