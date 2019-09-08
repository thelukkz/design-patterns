namespace FacadePattern.Subsystem
{
    public class EquityFactory
    {
        public EquityFactory()
        {

        }

        private static EquityFactory _instance;

        public static EquityFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new EquityFactory();
            }

            return _instance;
        }

        public Equity CreateEquity(string tickerSymbol)
        {
            return new Stock(tickerSymbol);
        }
    }
}
