namespace IJDEVLibrary.SOLID_ILLustration
{
    public class RelatorioFinanceiroViolaSRP
    {
        /*
         Violação de SRP (Single Responsibility Principle)
         A classe faz várias coisas: gera relatório, salva em arquivo e envia por email.
         Ela tem múltiplas responsabilidades.
         */

        public string GerarRelatorio()
        {
            return "Relatório financeiro gerado com sucesso.";
        }
        public void SalvarEmArquivo(string relatorio)
        {
            Console.WriteLine($"Relatório salvo: <{relatorio}>.");
        }
        public void EnviarPorEmail(string relatorio, string? email = null)
        {
            email = email ?? "default@example.com";
            Console.WriteLine($"Relatório <{relatorio}> enviado para <{email}>.");
        }
    }

    /* 
       Aplicando o SRP (Single Responsibility Principle) corretamente.
       Uma classe tem apenas uma responsabilidade: gerar o relatório financeiro.
       Outras responsabilidades (salvar e enviar) são delegadas a classes separadas.
    */

    // 1. SRP - Uma classe com responsabilidade única
    public class RelatorioFinanceiro
    {
        public string GerarRelatorio()
        {
            return "Relatório financeiro gerado com sucesso.";
        }
    }

    // Classe separada para salvar relatórios (não misturamos responsabilidades)
    public class RelatorioSaver
    {
        public void Salvar(string relatorio)
        {
            Console.WriteLine($"Relatório salvo: <{relatorio}>.");
        }
    }

    // Classe separada para enviar relatórios por email (não misturamos responsabilidades)
    public class RelatorioEmailSender
    {
        public void Enviar(string relatorio, string? email = null)
        {
            email = email ?? "default@example.com";
            Console.WriteLine($"Relatório <{relatorio}> enviado para <{email}>.");
        }
    }
}