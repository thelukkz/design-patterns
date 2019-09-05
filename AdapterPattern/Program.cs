using AdapterPattern.Concrete;
using System;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StockApp app = new StockApp();

            app.ShowStockHistory("AAPL");

            Console.ReadKey();
        }
    }
}
