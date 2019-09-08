using FacadePattern.Concrete;
using System;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mutualFund = new MutualFund(1234567);
            mutualFund.Buy("AAPL", 10);

            Console.ReadKey();
        }
    }
}
