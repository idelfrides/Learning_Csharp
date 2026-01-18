/*
 
  This project is a library that contains class and methods to be tested with unit tests at other project created specificaly for that purpose
for a simple bank account class using MSTest framework.

*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankAccount
    {
        private readonly string m_customerName;
        private double m_balance;

        // constructor
        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName;  }
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
            } else
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

        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("Mr. Barack Obama", 7000);

            ba.DisplayBalance();
            ba.Credit(1000);
            ba.DisplayBalance();
            ba.Debit(10000);
            ba.DisplayBalance();
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
