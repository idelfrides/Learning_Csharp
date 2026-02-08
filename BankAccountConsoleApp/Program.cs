using BankAccountLibrary;
using IJDEVLibrary;

namespace BankAccountConsoleApp
{

    /// <summary>
    /// Bank account console application to demonstrate basic banking operations using the BankAccountLibrary.
    /// </summary>
    public class BankAccountConsoleApp
    {

        public static void Main(string[] args)
        {

            #region bloco ------------------ START OF APP ----------------------
            AppInputOutputManager ijlibs = new();

            ijlibs.ShowAppInfo(
                title: "Bank Account Console Application",
                summary: "This App simulates basic banking operations using the BankAccountLibrary."
            );
            #endregion

            #region bloco ------------------ BANKACCOUNT LIBRARY: real testAPP goes HERE -----------------------

            BankAccount ba = new BankAccount("Mr. Barack Obama", 7000);

            ba.DisplayBalance();
            ba.Credit(1000);
            ba.DisplayBalance();
            //ba.Debit(0);          // will cause exception
            //ba.Debit(-100);       // will cause exception
            ba.Debit(8000);         // valid amount will execute the withdraw without exception
            ba.DisplayBalance();

            #endregion

            #region bloco ------------------ Conclusion: END OF APP --------------------

            ijlibs.ShowAppEndInfo();

            #endregion
        }
    }
}

