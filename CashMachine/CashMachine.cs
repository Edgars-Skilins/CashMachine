using CashMachine.Exceptions;

namespace CashMachine
{
    public class CashMachine : ICashMachine
    {
        public void Insert(int[] cash)
        {
            int[] allowedBanknotes = new int[] { 5, 10, 20, 50, 100 };

            foreach (var banknote in cash)
            {
                if (!allowedBanknotes.Contains(banknote))
                {
                    throw new BanknoteNotSupportedException("The cash machine does not support inserted banknote");
                }
            }
        }

        public int Withdraw(int amount)
        {
            if (amount % 5 != 0)
            {
                throw new IncorrectAmountException("Can not withdraw amount that does not divide by 5");
            }

            return amount;
        }
    }
}
