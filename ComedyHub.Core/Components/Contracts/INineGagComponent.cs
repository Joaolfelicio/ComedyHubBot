﻿using ComedyHub.Core.Infrastructure.NineGagModels;
using ComedyHub.Core.Infrastructure.NineGagModels.Models;
using ComedyHub.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComedyHub.Core.Components.Contracts
{
    public interface INineGagComponent
    {

        Task<MemeModel> GetNineGagMeme();
    }
}