﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXFreight.Core.Models
{
    public class LogoutInfo
    {
        [JsonProperty(PropertyName = "LogoutResult")]
        public int LogoutResult { get; set; }
    }
}
