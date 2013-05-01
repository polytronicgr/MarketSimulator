﻿using System.Data;

namespace MarketSimulator.MarketDataRetriever
{
    /// <summary>
    /// IMarketDataRetriever
    /// </summary>
    public interface IMarketDataRetriever
    {
        /// <summary>
        /// Retrieve
        /// </summary>
        /// <param name="symbol"></param>
        /// <returns></returns>
        DataTable Retrieve(string symbol);
    }
}