using System;
using System.Collections.Generic;
using System.Text;

namespace IJDEVLibrary.SOLID_ILLustration
{

    public class RepositorioBanco
    {
        public void Salvar(string dado) => Console.WriteLine($"Salvando no banco: {dado}");
    }

    // Violação de DIP (Dependency Inversion Principle)
    // O serviço depende diretamente de uma implementação concreta (RepositorioBanco).
    // Isso gera alto acoplamento e dificulta testes.
    public class Servico
    {
        private readonly RepositorioBanco _repositorio;

        public Servico()
        {
            _repositorio = new RepositorioBanco(); // Dependência concreta
        }

        public void Processar(string dado)
        {
            // Lógica de processamento...
            Console.WriteLine("Processando dado ... ");
            _repositorio.Salvar(dado); // Dependência direta
        }
    }

    // 5. DIP - Dependência de abstrações
    public interface IRepositorio
    {
        void Salvar(string dado);
    }
    public class RepositorioBancoAbstrato : IRepositorio
    {
        public void Salvar(string dado) => Console.WriteLine($"Salvando no banco: {dado}");
    }

    public class ServicoAbstrato
    {
        private readonly IRepositorio _repositorio;

        public ServicoAbstrato(IRepositorio repositorio)
        {
            _repositorio = repositorio;
        }

        public void Executar(string dado)
        {
            // Lógica de processamento...
            Console.WriteLine("Executanto ação ...");
            _repositorio.Salvar(dado);
        }
    }

    public class DependencyInversionPrinciple
    {
    }
}
