using IJDEVLibrary;
using IJDEVLibrary.LogsHandler;
using IJDEVLibrary.SOLID_ILLustration;

namespace SOLIDProjectDemo
{

    public class LSPDemoProgram
    {

        public static void MainLSP(string[] args)
        {

            #region block code 1 --------- START OF APP ----------------------

            // Instance section
            // In this section, you can instantiate all the classes you will use in the application.
            JCustomLogger logger = new("LSPDemo");
            AppInputOutputManager iom = new();

            // Value definition for Constants and fields section
            var infos = "LEARNING AND PRACTICING SOLID CONCEPTS EM C#";
            var summary = "This App attempts to show how to apply in code the concept of <Liskov Substitution Principle (LSP)>. \n I will show the violation and the correct approch of <LSP>";
            char lineShape = '*';
            int lineLen = 0;
            int vspace = 2;
            int hspace = 0;
            bool useTab = false;

            // Instance member call section
            iom.ShowAppInfo(title: infos, summary: summary);

            #endregion // --- starting app region ends here ---

            #region block code 2 --------- THE LOGIC OF APP GOES HERE --------

            logger.Info("region block code 2 --------- THE LOGIC OF APP GOES HERE --------");

            #region LSP - Liskov Substitution Principle : Violation approach
            summary = """                
               Violação de LSP (Liskov Substitution Principle)
               ContaPoupanca não permite saque, mas herda de Conta.
               Isso quebra a substituição: não podemos usar ContaPoupanca no lugar de Conta.              
            """;

            infos = "Demonstrating the violation of LSP";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine(summary);

            int money;
            money = iom.GetRandomIntValue(maxValue: 5000);

            Conta accio = new ContaPoupanca();
            logger.Info($"Operação de Saque em <Conta Poupança> | Valor solicitado: {money}");
            //accio.Sacar(money); // will show InvalidOperationException

            #endregion

            #region LSP - Liskov Substitution Principle : Correct approach

            summary = """
                3. LSP - Substituição sem quebrar
               ContaCorrente permite saque, logo faz sentido herdar a classe Conta.
               Isso mantém a substituição: podemos usar ContaCorrente no lugar de Conta.
            """;

            infos = "Demonstrating the correct application of LSP";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine(summary);

            money = iom.GetRandomIntValue(maxValue: 2000);
            accio = new ContaCorrente();
            logger.Info($"Operação de Saque em <Conta Corrente> | Valor solicitado: {money}\n\n");
            accio.Sacar(money); // will perform the operation correctly
            #endregion

            #endregion // --- the logic of app region ends here ---

            #region block code 3 --------- END OF APP ------------------------

            iom.ShowAppEndInfo();

            #endregion // --- closing region ends here ---

        }
    }
}
