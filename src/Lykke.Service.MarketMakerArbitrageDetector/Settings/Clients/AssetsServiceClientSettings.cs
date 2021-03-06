﻿using JetBrains.Annotations;
using Lykke.SettingsReader.Attributes;

namespace Lykke.Service.MarketMakerArbitrageDetector.Settings.Clients
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AssetsServiceClientSettings
    {
        [HttpCheck("api/isalive")]
        public string ServiceUrl { get; set; }
    }
}
