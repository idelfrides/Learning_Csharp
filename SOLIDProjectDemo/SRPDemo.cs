
using IJDEVLibrary;
using IJDEVLibrary.LogsHandler;
using IJDEVLibrary.SOLID_ILLustration;

namespace SOLIDProjectDemo;

public class SRPDemo
{
    
    public static void MainSRP(string[] args)
    {

        #region block code 1 --------- START OF APP ----------------------

        // Instance section
        // In this section, you can instantiate all the classes you will use in the application.
        JCustomLogger logger = new("SRPDemo");
        AppInputOutputManager iom = new();

        // Value definition for Constants and fields section
        var infos = "LEARNING AND PRACTICING SOLID CONCEPTS EM C#";
        var summary = "This App attempts to show how to apply in code the concept of <Single Responsibility Principle (SRP)>. \n I will show the violation and the correct approch of <SRP>";
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

        infos = "Demonstrating the violation of SRP";
        iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);

        // Demonstrating the violation of SRP
        /*
           Violação de SRP (Single Responsibility Principle)
           A classe 'RelatorioFinanceiroViolaSRP' faz várias coisas: 
                - gera relatório
                - salva em arquivo
                - envia por email
           Ela tem, portanto, múltiplas responsabilidades.
        */
        var relatorio = new RelatorioFinanceiroViolaSRP();
        var relatorioGerado = relatorio.GerarRelatorio();
        relatorio.SalvarEmArquivo(relatorioGerado);
        relatorio.EnviarPorEmail(relatorioGerado);

        // Demonstrating the correct application of SRP
        infos = "Demonstrating the correct application of SRP";
        iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);

        var relatorioCorreto = new RelatorioFinanceiro();
        var relatorioGeradoCorreto = relatorioCorreto.GerarRelatorio();

        new RelatorioSaver().Salvar(relatorioGeradoCorreto);

        new RelatorioEmailSender().Enviar(relatorioGeradoCorreto);

        #endregion // --- the logic of app region ends here ---


        #region block code 3 --------- END OF APP ------------------------

        iom.ShowAppEndInfo();

        #endregion // --- closing region ends here ---

    }
}