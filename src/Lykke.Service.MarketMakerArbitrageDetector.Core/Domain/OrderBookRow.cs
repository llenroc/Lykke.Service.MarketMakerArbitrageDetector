﻿using System;
using System.Collections.Generic;

namespace Lykke.Service.MarketMakerArbitrageDetector.Core.Domain
{
    public class OrderBookRow
    {
        public string Source { get; }

        public AssetPair AssetPair { get; }

        public IReadOnlyCollection<string> MarketMakers { get; }

        public decimal? BestBid { get; }

        public decimal? BestAsk { get; }

        public decimal BidsVolume { get; }

        public decimal? BidsVolumeInUsd { get; }

        public decimal AsksVolume { get; }

        public decimal? AsksVolumeInUsd { get; }

        public DateTime Timestamp { get; }


        public OrderBookRow(string source, AssetPair assetPair, decimal? bestBid, decimal? bestAsk,
            decimal bidsVolume, decimal? bidsVolumeInUsd, decimal asksVolume, decimal? asksVolumeInUsd, DateTime timestamp,
            IReadOnlyCollection<string> marketMakers)
        {
            Source = source;
            AssetPair = assetPair;
            MarketMakers = marketMakers;
            BestBid = bestBid;
            BestAsk = bestAsk;
            BidsVolume = bidsVolume;
            BidsVolumeInUsd = bidsVolumeInUsd;
            AsksVolume = asksVolume;
            AsksVolumeInUsd = asksVolumeInUsd;
            Timestamp = timestamp;
        }

        public override string ToString()
        {
            return $"{Source} - {AssetPair}";
        }
    }
}
