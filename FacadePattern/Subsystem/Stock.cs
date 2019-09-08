using System;

namespace FacadePattern.Subsystem
{
    public class Stock : Equity
    {
        public Stock(string tickerSymbol) : base(tickerSymbol)
        {

        }

        public override void Buy(decimal shares)
        {
            
        }

        public override void Sell(decimal shares)
        {
            throw new NotImplementedException();
        }

        public override decimal GetPrices()
        {
            return 10;
        }
    }
}
