﻿using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;

namespace Lykke.Service.MarketMakerArbitrageDetector.Client.Models.OrderBooks
{
    public class OrderBook
    {
        public string Exchange { get; set; }

        public AssetPair AssetPair { get; set; }

        public IReadOnlyList<LimitOrder> Bids { get; set; }

        public IReadOnlyList<LimitOrder> Asks { get; set; }

        public LimitOrder BestBid => Bids.Any() ? Bids.MaxBy(x => x.Price) : null;

        public LimitOrder BestAsk => Asks.Any() ? Asks.MinBy(x => x.Price) : null;

        public decimal BidsVolume => Bids.Sum(x => x.Volume);

        public decimal AsksVolume => Asks.Sum(x => x.Volume);

        public DateTime Timestamp { get; set; }

        public override string ToString()
        {
            return $"{Exchange} - {AssetPair}, BestBid: {BestBid:0.#####}, BestAsk: {BestAsk:0.#####}, Bids: {Bids.Count}, Asks: {Asks.Count}, Timestamp: {Timestamp}";
        }
    }
}
