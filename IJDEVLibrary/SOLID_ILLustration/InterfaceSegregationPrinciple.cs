using System;
using System.Collections.Generic;
using System.Text;

namespace IJDEVLibrary.SOLID_ILLustration
{

    // Violação de ISP (Interface Segregation Principle)
    // IDispositivoMultifuncionalViolaISP é uma interface genérica
    // que inclui métodos para imprimir, escanear e enviar fax.
    // A interface força a implementação de métodos que nem todas as classes precisam.
    public interface IDispositivoMultifuncionalViolaISP
    {
        void Imprimir(string documento);
        void Escanner(string documento);
        void Fax(string documento);
    }
    public class ImpressoraSinples : IDispositivoMultifuncionalViolaISP
    {
        public void Imprimir(string documento) => Console.WriteLine($"Imprimindo: {documento}");

        // Métodos desnecessários para uma impressora simples: Escanear e Fax
        public void Escanner(string documento)
        {
            throw new NotImplementedException("Este dispositivo não suporta escaneamento.");
        }
        public void Fax(string documento)
        {
            throw new NotImplementedException("Este dispositivo não suporta fax.");
        }
    }

    // 4. ISP - Interfaces específicas
    
    public interface IImpressora
    {
        void Imprimir(string documento);
    }
    public interface IEscanner
    {
        void Escanear(string documento);
    }
    public interface IFax
    {   
        void EnviarFax(string documento);
    }

    public class ImpressoraSinplesV2 : IImpressora
    {
        public void Imprimir(string documento) => Console.WriteLine($"Imprimindo: {documento}");
    }
    public class Scanner : IEscanner
    {
        public void Escanear(string documento) => Console.WriteLine($"Escaneando: {documento}");
    }
    public class Fax : IFax
    {
        public void EnviarFax(string documento) => Console.WriteLine($"Enviando Fax: {documento}");
    }

    public class InterfaceSegregationPrinciple
    {
    }
}
