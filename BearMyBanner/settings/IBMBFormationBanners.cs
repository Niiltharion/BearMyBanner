﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BearMyBanner.Settings
{
    public interface IBMBFormationBanners
    {

        string Infantry { get; set; }
        string Ranged { get; set; }
        string Cavalry { get; set; }
        string HorseArcher { get; set; }
        string Skirmisher { get; set; }
        string HeavyInfantry { get; set; }
        string LightCavalry { get; set; }
        string HeavyCavalry { get; set; }
    }
}
