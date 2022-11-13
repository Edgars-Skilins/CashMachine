using Xunit;
using CashMachine.Exceptions;

namespace CashMachine.Tests
{
    public class CashMachineTest
    {
        [Fact]
        public void InsertTestAcceptableBankNotes()
        {
            CashMachine cashMachine = new CashMachine();

            try
            {
                cashMachine.Insert(new int[] { 5, 10, 20, 50, 100 });
                Assert.True(true);
            }
            catch
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void InsertTestWrongBankNote()
        {
            CashMachine cashMachine = new CashMachine();

            Assert.Throws<BanknoteNotSupportedException>(() => cashMachine.Insert(new int[] { 5, 10, 20, 50, 100, 7 }));
        }

        [Fact]
        public void WithdrawTestSuccesfulWithdrawl()
        {
            CashMachine cashMachine = new CashMachine();

            var withdrawl = cashMachine.Withdraw(0);

            Assert.IsType<int>(withdrawl);
            Assert.Equal(0, withdrawl); 
            
            withdrawl = cashMachine.Withdraw(5);

            Assert.IsType<int>(withdrawl);
            Assert.Equal(5, withdrawl);

            withdrawl = cashMachine.Withdraw(50);

            Assert.IsType<int>(withdrawl);
            Assert.Equal(50, withdrawl);

            withdrawl = cashMachine.Withdraw(105);

            Assert.IsType<int>(withdrawl);
            Assert.Equal(105, withdrawl);

            withdrawl = cashMachine.Withdraw(120);

            Assert.IsType<int>(withdrawl);
            Assert.Equal(120, withdrawl);
        }

        [Fact]
        public void WithdrawTestIncorrectAmountException()
        {
            CashMachine cashMachine = new CashMachine();

            Assert.Throws<IncorrectAmountException>(() => cashMachine.Withdraw(72));
        }
    }
}