using System.Runtime.CompilerServices;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!\n Eu sou o IJDEV PRO. Este é o meu app em C#!");

        // TÓPICO 1 - Declaração de variáveis E tipos de dados
        int numero = 10;
        float decimalNumero = 20.5f;
        string texto = "Este é um texto em C#";
        double numeroGrande = 123456789.12345;
        bool booleano = true;
        
        Console.WriteLine("\nO número é: " + numero);
        Console.WriteLine("\nO número decimal é: " + decimalNumero);
        Console.WriteLine("O texto é: " + texto);
        Console.WriteLine("O número grande é: " + numeroGrande);
        Console.WriteLine("O valor booleano é: " + booleano);

        Console.WriteLine("Digite seu nome::>>   ");
        var inputContent = Console.ReadLine();
        var currentDatetime = DateTime.Now;
        Console.WriteLine("Olá, " + inputContent + "! Hoje é " + currentDatetime.ToString("dd/MM/yyyy") + " e são " + 
        currentDatetime.ToString("HH:mm:ss")
        );
        
        Console.Write($"{Environment.NewLine}Pressione qualquer tecla para sair...");

        Console.ReadKey(true);

    }
}

