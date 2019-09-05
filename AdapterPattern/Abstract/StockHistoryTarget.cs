using System;
using System.Data;

namespace AdapterPattern.Abstract
{
    public abstract class StockHistoryTarget
    {
        public abstract DataTable GetStockPrices(string ticker);
    }
}
