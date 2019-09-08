namespace FacadePattern.Subsystem
{
    public abstract class Equity
    {
        private string _tickerSymbol = null;

        public Equity(string tickerSymbol)
        {
            _tickerSymbol = tickerSymbol;
        }

        public abstract void Buy(decimal shares);

        public abstract void Sell(decimal shares);

        public abstract decimal GetPrices();
    }
}
