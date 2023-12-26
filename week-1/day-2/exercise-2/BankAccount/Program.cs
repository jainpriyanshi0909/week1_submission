namespace BankAccount
{
    public abstract class BankAccount
    {
        public int AccountNumber;
        protected int Balance;
        public BankAccount(int ACCOUNTNO, int Balance)
        {
            AccountNumber = ACCOUNTNO;
            this.Balance = Balance;
        }
        public virtual void deposit(int addedBalance)
        { Balance += addedBalance; }
        
        public int withdraw(int amountToWithdraw)
        {
            if (Balance > amountToWithdraw)
            {
                Balance -= amountToWithdraw;
                Console.WriteLine(Balance);
                return 1;
            }
            else
            {
                Console.WriteLine("Balance is less.");
                return 0;
            }
        }
    }
    public class SavingAccount : BankAccount
    {
        private int InterestRate;
        public SavingAccount(int accountno, int balance, int interestRate) : base(accountno, balance)
        {
            InterestRate = interestRate;
        }
        public override void deposit(int addedBalance)
        {
            Balance += addedBalance;
            Console.WriteLine("Balance :" + Balance + " Intersetrate :" + InterestRate);
        }

    }
    public class CheckingAccount : BankAccount
    {
        private int overDraftLimit;
        public CheckingAccount(int accountno, int balance, int overDraftLimit) : base(accountno, balance)
        {
            this.overDraftLimit = overDraftLimit;
        }
        public override void deposit(int addedBalance)
        {
            Balance += addedBalance;
            Console.WriteLine("Balance :" + Balance + " overDraftLimit :" + overDraftLimit);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create SavingsAccount and CheckingAccount objects and perform operations
            SavingAccount mySavingAccount = new SavingAccount(946116, 2000, 5);
            mySavingAccount.deposit(1000);
            int isdeposited = mySavingAccount.withdraw(4000);
            Console.WriteLine(isdeposited);
            CheckingAccount myCheckingAccount = new CheckingAccount(961054, 20000, 5);
            myCheckingAccount.deposit(1000);
            int isdepositedchecking = myCheckingAccount.withdraw(4000);
            Console.WriteLine(isdepositedchecking);
        }
    }
}