﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ComedyHub.Core.Infrastructure.Gateway.Models.NineGagModels
{
    public class Data
    {
        public List<NineGagPost> Posts { get; set; }
        public string NextCursor { get; set; }
    }
}
