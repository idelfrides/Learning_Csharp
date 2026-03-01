using System;
using System.Collections.Generic;
using System.Text;

namespace IJDEVLibrary.SOLID_ILLustration
{

    // Violação de OCP (Open/Closed Principle)
    // Para adicionar um novo tipo de desconto, precisamos modificar a classe.
    // Isso quebra o princípio de estar "fechado para modificação".
    public class CalculadoraDescontoViolaOCP
    {
        public decimal Calcular(string tipo, decimal valor)
        {
            if (tipo == "Natal") 
                return valor * 0.9m;     // 10% de desconto
            else if (tipo == "AnoNovo") 
                return valor * 0.85m;    // 15% de desconto
            else if (tipo == "BlackFriday") 
                return valor * 0.8m;     // 20% de desconto
            else
                return valor;            // Sem desconto
        }
        
    }
    
    // 2. OCP - Aberto para extensão, fechado para modificação
    public abstract class Desconto
    {
        public abstract decimal Calcular(decimal valor);
    }

    public class DescontoNatal : Desconto
    {
        public override decimal Calcular(decimal valor) => valor * 0.7m;
    }

    public class DescontoAnoNovo : Desconto
    {
        public override decimal Calcular(decimal valor)
        {
            return valor * 0.80m;
        }
    }

    public class DescontoBlackFriday : Desconto
    {
        public override decimal Calcular(decimal valor) => valor * 0.85m;
    }
    
    public class OpenClosedPrinciple
    {
    }

}
