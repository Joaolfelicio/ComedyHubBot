﻿using ComedyHub.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComedyHub.Core.Services.Contracts
{
    public interface IPublishTwitterService
    {
        void PublishTwitter(MemeModel memeModel);
    }
}
