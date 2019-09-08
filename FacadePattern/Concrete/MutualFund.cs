using FacadePattern.Subsystem;
using System;

namespace FacadePattern.Concrete
{
    public class MutualFund
    {
        private int _accountNumber = 0;

        public MutualFund(int accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public void Buy(string tickerSymbol, int shares)
        {
            CashAccount account = new CashAccount(_accountNumber);
            var equityFactory = EquityFactory.GetInstance();
            Equity equity = equityFactory.CreateEquity(tickerSymbol);

            decimal amount = equity.GetPrices() * shares;
            decimal balance = account.GetAccountBalance();
            if (balance >= amount)
            {
                account.Withdraw(amount);

                equity.Buy(shares);
                Console.WriteLine("Succesfully bought {0} {1} shares", shares, tickerSymbol);
                Console.WriteLine("New account balance is ${0}", account.GetAccountBalance());
            }
            else
            {
                Console.WriteLine("Insufficient balance ${0}", balance);
            }
        }
    }
}
