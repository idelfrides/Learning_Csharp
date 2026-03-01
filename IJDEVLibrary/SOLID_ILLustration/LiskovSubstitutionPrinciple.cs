using System;
using System.Collections.Generic;
using System.Text;

namespace IJDEVLibrary.SOLID_ILLustration
{
    public class LiskovSubstitutionPrinciple
    {
    }

    // Violação de LSP (Liskov Substitution Principle)
    // ContaPoupanca não permite saque, mas herda de Conta.
    // Isso quebra a substituição: não podemos usar ContaPoupanca no lugar de Conta.
    
    public class Conta
    {
        public virtual void Sacar(decimal valor)
        {
            Console.WriteLine($"Saque de {valor} realizado.");
        }
    }
    public class ContaPoupanca : Conta
    {
        public override void Sacar(decimal valor)
        {
            throw new InvalidOperationException("Saque não permitido em conta poupança.");
        }
    }

    // 3. LSP - Substituição sem quebrar
    public class ContaCorrente : Conta
    {
        public override void Sacar(decimal valor)
        {
            Console.WriteLine($"Saque de {valor} realizado na conta corrente.");
        }
    }

}
