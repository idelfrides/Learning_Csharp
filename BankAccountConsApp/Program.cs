using System;

namespace BankAccountConsApp
{
    /// <summary>
    /// Bank account demo class  for console application.
    /// </summary>
    public class BankAccountConsoleApp
    {
        private readonly string m_customerName;
        private double m_balance;

        // constructor
        private BankAccountConsoleApp() { }

        public BankAccountConsoleApp(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
        }

        // automatic property for Balance
        public double Balance
        {
            get { return m_balance; }
        }

        //public double Balance { get; set; }
        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                m_balance += amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be greater than zero");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > m_balance)
            {
                throw new InvalidOperationException("Insufficient funds for this withdrawal");
            }
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Withdrawal amount must be positive");
            }
            m_balance -= amount;    // corret operation
            //m_balance += amount;   // intentionally incorrect operation
        }

        public void DisplayBalance()
        {
            Console.WriteLine("\n\n ACION: DisplayBalance \n");
            Console.WriteLine($"The current balance for account of {m_customerName} is {m_balance:C}");
        }

        public void Debit(double amount)
        {
            Console.WriteLine($"\n\n ACION: Debit of {amount} \n");
            Withdraw(amount);
        }

        public void Credit(double amount)
        {
            Console.WriteLine($"\n\n ACION: Credit of {amount} \n");
            Deposit(amount);
        }

        static void MaiBApp(string[] args)
        {
            BankAccountConsoleApp ba = new BankAccountConsoleApp("Mr. Barack Obama", 7000);

            //ba.DisplayBalance();
            //ba.Credit(1000);
            ba.DisplayBalance();
            //ba.Debit(0);          // will cause exception
            //ba.Debit(-100);       // will cause exception
            ba.Debit(1000);         // valid amount will execute the withdraw without exception
            //ba.DisplayBalance();
            Console.WriteLine("Current balance is ${0}", ba.Balance);


            #region bloco ---------------- Conclusion: END OF APP --------------------

            Console.Write("\n\n\n============================= END OF THE APP ================================\n\n");
            Console.Write($"{Environment.NewLine}\nPress any Key to Leave the APP . . .\n\n\n\n");

            Console.ReadKey(true);
            Environment.Exit(0);

            #endregion
        }
    }
}
