using Bank.Entities.Exceptions;
namespace Bank.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account()
        {
        }
        public Account(int number, string holder,
         double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > Balance)
            {
                throw new MainException("\nWithdraw error: Not enough balance\n");
            }
            else if (amount > WithdrawLimit)
            {
                throw new MainException("\nWithdraw error: The amount exceeds withdraw limit\n");
            }
            Balance -= amount;
        }
    }
}