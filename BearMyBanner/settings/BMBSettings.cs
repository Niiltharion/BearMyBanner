﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaleWorlds.Library;

namespace BearMyBanner.Settings
{
    [Serializable]
    public class BMBSettings : IBMBSettings
    {
        public static IBMBSettings Instance => GetInstance();

        private static IBMBSettings _settings;

        private static IBMBSettings GetInstance()
        {
            if (_settings == null)
            {
                _settings = SettingsLoader.LoadBMBSettings();
            }
            return _settings;
        }

        internal BMBSettings()
        {
        }

        public bool AllowSieges { get; set; }
        public bool SiegeAttackersUseBanners { get; set; }
        public bool SiegeDefendersUseBanners { get; set; }
        public bool AllowHideouts { get; set; }
        public bool HideoutAttackersUseBanners { get; set; }
        public bool HideoutBanditsUseBanners { get; set; }
        public bool TournamentBanners { get; set; }
        public bool TournamentThemes { get; set; }
        public bool TournamentBannersInShields { get; set; }
        public int BearerToTroopRatio { get; set; }
        public bool UseTroopSpecs { get; set; }
        public bool AllowSoldiers { get; set; }
        public bool AllowCaravanGuards { get; set; }
        public bool AllowMercenaries { get; set; }
        public bool AllowBandits { get; set; }
        public bool AllowInfantry { get; set; }
        public bool AllowRanged { get; set; }
        public bool AllowMounted { get; set; }
        public bool AllowMountedRanged { get; set; }
        public bool FilterTiers { get; set; }
        public bool AllowTier1 { get; set; }
        public bool AllowTier2 { get; set; }
        public bool AllowTier3 { get; set; }
        public bool AllowTier4 { get; set; }
        public bool AllowTier5 { get; set; }
        public bool AllowTier6 { get; set; }
        public bool AllowTier7Plus { get; set; }
        public bool AllowPlayer { get; set; }
        public bool AllowCompanions { get; set; }
        public bool AllowNobles { get; set; }
        public bool ShowMessages { get; set; }
        public bool WhiteMessages { get; set; }

    }
}
