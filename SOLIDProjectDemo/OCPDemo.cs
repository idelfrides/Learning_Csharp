using IJDEVLibrary;
using IJDEVLibrary.LogsHandler;
using IJDEVLibrary.SOLID_ILLustration;

namespace SOLIDProjectDemo
{
    public class OCPDemoProgram
    {
        public static void MainOCP(string[] args)
        {

            #region block code 1 --------- START OF APP ----------------------

            // Instance section
            // In this section, you can instantiate all the classes you will use in the application.
            JCustomLogger logger = new("OCPDemo");
            AppInputOutputManager iom = new();

            // Value definition for Constants and fields section
            var infos = "LEARNING AND PRACTICING SOLID CONCEPTS EM C#";
            var summary = "This App attempts to show how to apply in code the concept of <Open/Closed Principle (OCP)>. \n I will show the violation and the correct approch of <OCP>";
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

            // Demonstrating the violation of OCP
            summary = """                
                Violação de OCP (Open/Closed Principle)
                Para adicionar um novo tipo de desconto, precisamos modificar a classe.
                Isso quebra o princípio de estar "fechado para modificação".
            """;

            infos = "Demonstrating the violation of OCP";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine(summary);

            int productPrice;
            productPrice = iom.GetRandomIntValue(maxValue: 5000);

            var tipoDesconto = "Natal";
            var calculaDesc = new CalculadoraDescontoViolaOCP();
            var classResult = calculaDesc.Calcular(tipoDesconto, productPrice);

            logger.Info($"Desconto de tipo <{tipoDesconto}> | Valor Original: {productPrice} | Com Desconto: {classResult}");

            productPrice = iom.GetRandomIntValue(maxValue: 1000);
            tipoDesconto = "BlackFriday";
            classResult = calculaDesc.Calcular(tipoDesconto, productPrice);
            logger.Info($"Desconto de tipo <{tipoDesconto}> | Valor Original: {productPrice} | Com Desconto: {classResult}");

            productPrice = iom.GetRandomIntValue(maxValue: 2000);
            tipoDesconto = "AnoNovo";
            classResult = calculaDesc.Calcular(tipoDesconto, productPrice);
            logger.Info($"Desconto de tipo <{tipoDesconto}> | Valor Original: {productPrice} | Com Desconto: {classResult}");


            // Demonstrating the correct application of OCP
            summary = """                
                2. OCP - Aberto para extensão, fechado para modificação
                Para adicionar um novo tipo de desconto, basta criar uma nova classe que herda a classe base
                'Desconto' e aplicar a lógica correspondente.
                Neste caso, isso não quebra o princípio de estar "fechado para modificação".
                Como demonstrado aqui, temos uma hierarquia de classes onde cada tipo de desconto 
                é implementado em uma classe separada, permitindo a extensão sem a necessidade de modificar 
                o código existente.
                As seguintes classes possiblitam a aplicação correta do OCP:
                  - DescontoNatal: Aplica um desconto de 30% para o Natal.
                  - DescontoAnoNovo: Aplica um desconto de 20% para o Ano Novo.
                  - DescontoBlackFriday: Aplica um desconto de 15% para a Black Friday.
            """;

            infos = "Demonstrating the correct application of OCP";
            iom.ShowPrettyInfo(infos, lineShape, lineLen, vspace, hspace, useTab);
            Console.WriteLine(summary);
            
            productPrice = iom.GetRandomIntValue(maxValue: 2000);

            Desconto dio = new DescontoNatal();
            classResult = dio.Calcular(productPrice);
            logger.Info($"Desconto de tipo <Natal> | Valor Original: {productPrice} | Com Desconto: {classResult}");

            dio = new DescontoBlackFriday();
            //productPrice = iom.GetRandomIntValue(maxValue: 2000);
            classResult = dio.Calcular(productPrice);
            logger.Info($"Desconto de tipo <BlackFriday> | Valor Original: {productPrice} | Com Desconto: {classResult}");

            dio = new DescontoAnoNovo();
            //productPrice = iom.GetRandomIntValue(maxValue: 3000);
            classResult = dio.Calcular(productPrice);
            logger.Info($"Desconto de tipo <AnoNovo> | Valor Original: {productPrice} | Com Desconto: {classResult}");

            #endregion // --- the logic of app region ends here ---


            #region block code 3 --------- END OF APP ------------------------

            iom.ShowAppEndInfo();

            #endregion // --- closing region ends here ---

        }
    }
}
