using IJDEVLibrary;
using IJDEVLibrary.LogsHandler;
using IJDEVLibrary.SOLID_ILLustration;

namespace SOLIDProjectDemo
{

    public class DIPDemoProgram
    {

        public static void Main(string[] args)
        {

            #region block code 1 --------- START OF APP ----------------------

            // Instance section
            // In this section, you can instantiate all the classes you will use in the application.
            JCustomLogger logger = new("DIPDemo");
            AppInputOutputManager iom = new();

            // Value definition for Constants and fields section
            var infos = "LEARNING AND PRACTICING SOLID CONCEPTS EM C#";
            var summary = "This App attempts to show how to apply in code the concept of <Dependency Inversion Principle (DIP)>. \n I will show the violation and the correct approch of <DIP>";
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

            #region DIP - Dependency Inversion Principle : Violation approach
            summary = """                
                Violação de DIP (Dependency Inversion Principle)
                O serviço depende diretamente de uma implementação concreta (RepositorioBanco).
                Isso gera alto acoplamento e dificulta testes.
            """;

            infos = "Demonstrating the violation of DIP";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine(summary);
            iom.BuildExternalSpaces("vertical", 2);

            var dado = "Exemplo de dado pra ser processado - violation of DIP";
            Servico servico = new();
            servico.Processar(dado);
            #endregion

            #region DIP - Dependency Inversion Principle : Correct approach

            summary = """
                5. DIP - Dependência de abstrações

                Em vez de depender de implementações concretas, o serviço depende de abstrações (interfaces).
                Isso reduz o acoplamento, facilita testes e permite trocar implementações sem modificar o serviço.
                Dessa forma alcançamos um design mais flexível e sustentável, 
                onde as partes do sistema podem evoluir de forma independente. 
            """;

            infos = "Demonstrating the correct application of DIP";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine(summary);
            iom.BuildExternalSpaces("vertical", 2);

            dado = "Dado para processamento de acordo com DIP";
            IRepositorio repositorio = new RepositorioBancoAbstrato();
            ServicoAbstrato sbserio = new(repositorio);
            sbserio.Executar(dado);

            #endregion

            #endregion // --- the logic of app region ends here ---

            #region block code 3 --------- END OF APP ------------------------

            iom.ShowAppEndInfo();

            #endregion // --- closing region ends here ---

        }
    }
}
