namespace FacadePattern.Subsystem
{
    public abstract class BankAccount
    {
        private int _accountNumber = 0;

        public BankAccount(int accountNumber)
        {
            _accountNumber = accountNumber;
        }

        public abstract decimal GetAccountBalance();

        public abstract void Withdraw(decimal amount);

        public abstract void Deposit(decimal amount);
    }
}
