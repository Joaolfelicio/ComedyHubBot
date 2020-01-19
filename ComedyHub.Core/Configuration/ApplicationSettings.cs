﻿using ComedyHub.Core.Configuration.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComedyHub.Core.Configuration
{
    public class ApplicationSettings : IApplicationSettings
    {
        public string ServicesToFetch { get; set; }
        public string DefaultTags { get; set; }
        public string ImagesExtensions { get; set; }
        public int SizeLimitMegaBytes { get; set; }
    }
}
