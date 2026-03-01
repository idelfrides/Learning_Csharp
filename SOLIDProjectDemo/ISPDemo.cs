using IJDEVLibrary;
using IJDEVLibrary.LogsHandler;
using IJDEVLibrary.SOLID_ILLustration;

namespace SOLIDProjectDemo
{

    public class ISPDemoProgram
    {

        public static void Main(string[] args)
        {

            #region block code 1 --------- START OF APP ----------------------

            // Instance section
            // In this section, you can instantiate all the classes you will use in the application.
            JCustomLogger logger = new("ISPDemo");
            AppInputOutputManager iom = new();

            // Value definition for Constants and fields section
            var infos = "LEARNING AND PRACTICING SOLID CONCEPTS EM C#";
            var summary = "This App attempts to show how to apply in code the concept of <Interface Segregation Principle (ISP)>. \n I will show the violation and the correct approch of <ISP>";
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

            #region ISP - Interface Segregation Principle : Violation approach
            summary = """                
                Violação de ISP (Interface Segregation Principle)
                IDispositivoMultifuncionalViolaISP é uma interface genérica
                que inclui métodos para imprimir, escanear e enviar fax.
                A interface força a implementação de métodos que nem todas as classes precisam.
            """;

            infos = "Demonstrating the violation of ISP";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine(summary);

            int money;
            money = iom.GetRandomIntValue(maxValue: 5000);
            var documento = "Documento de teste - violação de ISP";

            IDispositivoMultifuncionalViolaISP ispo = new ImpressoraSinples();
            ispo.Imprimir(documento);
            logger.Info($"Operação de Impressão em <Impressora Simples> | Documento: {documento}");

            // ispo.Escanear(documento); // will show NotImplementedException
            // ispo.Fax(documento); // will show NotImplementedException

            #endregion

            #region ISP - Interface Segregation Principle : Correct approach

            summary = """
                4. ISP - Interfaces específicas                         
                Em vez de uma interface genérica, temos aqui várias interfaces específicas para cada tipo de dispositivo.
                Isso permite que classes implementem apenas os métodos que realmente precisam.
                Isso mantém a coesão e evita a implementação de métodos desnecessários, 
                seguindo o princípio de segregação de interfaces.
            """;

            infos = "Demonstrating the correct application of ISP";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine(summary);

            documento = "Documento de teste - de acordo com ISP";

            // Impressora simples que implementa apenas a interface de impressão
            ImpressoraSinplesV2 ispcao = new();
            logger.Info($"Operação de Impressão em <Impressora Simples V2> | Documento: {documento}\n\n");
            ispcao.Imprimir(documento); // will perform the operation correctly

            // Scanner que implementa apenas a interface de escaneamento
            Scanner ispcao2 = new();
            logger.Info($"Operação de Escaneamento em <Scanner> | Documento: {documento}\n\n");
            ispcao2.Escanear(documento); // will perform the operation correctly

            // Fax que implementa apenas a interface de fax
            Fax ispcao3 = new();
            logger.Info($"Operação de Fax em <Fax> | Documento: {documento}\n\n");
            ispcao3.EnviarFax(documento); // will perform the operation correctly

            #endregion
        
            #endregion // --- the logic of app region ends here ---

            #region block code 3 --------- END OF APP ------------------------

            iom.ShowAppEndInfo();

            #endregion // --- closing region ends here ---

        }
    }
}
