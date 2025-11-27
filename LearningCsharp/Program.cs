using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"\n\nHello, World!{Environment.NewLine}Eu sou o IJDEV PRO. Este é o meu app em C#!");

        Console.Write("\n===================================================\n\n");

        Console.WriteLine("[AULA 6 - 9: VARIÁVEIS]: Tipos e Declaração de variáveis");
        Console.Write("\n===================================================\n\n");

        // TÓPICO 1 - Tipos e Declaração de variáveis em C#

        /*
        byte - 8 bits, valores de 0 a 255 é util
        sbyte - 8 bits, valores de -128 a 127
        short - 16 bits, valores de -32.768 a 32.767
        int - 32 bits, valores de -2.147.483.648 a 2.147.483.647
        long - 64 bits, valores de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
        float - 32 bits, precisão simples, usado para números decimais
        double - 64 bits, precisão dupla, usado para números decimais com maior precisão
        bool - 1 bit, valores true ou false
        char - 16 bits, representa um único caractere Unicode
        string - uma sequência de caracteres Unicode
        */

        // Atribuição de valores na Declaração de variáveis em C#
        int numero = 10;
        float decimalNumero = 20.5f;
        string texto = "Este é um texto em C#";
        bool booleano = true;
        var numeroVar = 100; // O compilador infere o tipo da variável de acordo com o valor atribuído
        var textoVar = "IDELFRIDES JORGE FERNANDES PAPAI";
        char caractere = 'I'; // Exemplo de variável do tipo char que representa um único caractere
        byte byteNumero = 255; // Exemplo de variável do tipo byte

        /* 
        ------ NOTA SOBRE 'var' EM C# ------
        Em C#, 'var' é usado para declaração implícita de variáveis. O compilador determina o tipo da variável com base no valor atribuído a ela no momento da declaração.
        Por esse motivo, o uso de 'var' requer obrigatoriamente que a variável seja inicializada no momento da declaração.

        RECOMENDAÇÃO DE USO DO TIPO 'var':
        1 -> É recomendado usar 'var' quando o tipo da variável é óbvio a   partir do valor atribuído, ou quando o tipo é complexo e longo, como em coleções genéricas.
        2 -> O uso do 'var' é útil para simplificar o código, mas deve levar me conta as restrições de tipo 'var'. Por exemplo, não se pode atribuir a uma variável do tipo 'var um valor de outro tipo posteriormente.
        */

        // numeroVar = "IJDEV PRO"; // Isso causará um erro de compilação, pois 'numeroVar' foi inferido como 'int' inicialmente.
    
        /// <summary>
        /// Este é um comentário XML em C# 
        /// inicia com três barras /// e é usado para documentação
        /// o bloco de comentário pode ter várias linhas
        /// e começa com a tag <summary> e termina com a tag </summary>
        /// utilizado para documentar classes, métodos, propriedades, etc.
        /// outra linha do comentário XML
        /// mais uma linha do comentário XML
        /// fim do comentário XML
        /// </summary>  

        // Declaração SEM atribuir valores ás variáveis em C#
        float decimalSemf;
        double numeroGrande;
        bool booleanFalse;
        string outroTexto;

        decimalSemf = 54.77f;
        numeroGrande = 123456789.12345;
        booleanFalse = false;
        outroTexto = "Outro texto em C# que não foi atribuído na declaração";

        Console.WriteLine("\t O número é: " + numero);
        Console.WriteLine("\t O número decimal é: " + decimalNumero);
        Console.WriteLine("\t O texto é: " + texto);
        Console.WriteLine("\t O número grande é: " + numeroGrande);
        Console.WriteLine("\t O valor booleano é: " + booleano);
        Console.WriteLine("\t O valor booleano falso é: " + booleanFalse);
        Console.WriteLine("\t O outro texto é: " + outroTexto);
        Console.WriteLine("\t O decimal sem f NO FINAL NÃO é PERMITIDO PELO COMPILADOR DO .NET:  " + decimalSemf);
        Console.WriteLine("\t O número com var é: " + numeroVar);
        Console.WriteLine("\t O texto com var é: " + textoVar);
        Console.WriteLine("\t O caractere é: " + caractere);
        Console.WriteLine("\t O número do tipo byte é: " + byteNumero);

        Console.Write("\n\n\n================== FIM DE APP ==================\n\n\n\n");


    }
}

