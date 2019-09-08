namespace FacadePattern.Subsystem
{
    public class CashAccount : BankAccount
    {
        protected decimal balance = 1000;
        public CashAccount(int accountNumber) : base(accountNumber)
        {

        }

        public override decimal GetAccountBalance()
        {
            return balance;
        }

        public override void Withdraw(decimal amount)
        {
            balance -= amount;
        }

        public override void Deposit(decimal amount)
        {
            balance += amount;
        }
    }
}
