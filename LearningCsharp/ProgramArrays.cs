namespace LearningCsharp
{   
    public class ProgramArrays
    {   

        public static void Main(string[] args)
        {
            // ----------------------- INÍCIO DE APP ------------------------
            Console.Write("\n===================================================\n\n");
            Console.WriteLine($"ESTUDANDO ARRAYS EM C#!");
            Console.Write   ("\n===================================================\n\n");

            // Declaração e Inicialização de um Array de inteiros com definição explícita de tamanho
            int[] numeros = new int[5] { 10, 20, 30, 40, 50 };  
            Console.WriteLine("Array de Números Inteiros:");
            foreach (int numero in numeros)
            {
                Console.WriteLine($"\tNúmero É => {numero}");
            } 

            // Declaração e Inicialização de um Array de strings sem definição explícita de tamanho
            string[] frutas = { "Maçã", "Banana", "Laranja", "Uva", "Manga", "Abacaxi", "Morango", "Melancia", "Pera", "Cereja", "Kiwi", "Ameixa", "Coco", "Limão", "Tangerina", "Goiaba", "Maracujá", "Pitanga", "Jabuticaba", "Carambola" };
            Console.WriteLine("\nArray de Frutas:");
            foreach (string fruta in frutas)
            {
                Console.WriteLine($"\tFruta => {fruta}");
            }  

            // Declaração e Inicialização de um Array multidimensional (matriz)
            int[,] matriz = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine("\nArray Multidimensional (Matriz):");    
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($"\t{matriz[i, j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // Array multidimencional 3D com foreach
            Console.WriteLine("Array Multidimensional 3D (Matriz) com foreach:");
            int[,,] matriz3D = new int[3, 2, 2]
            {
                { { 1, 2 }, { 3, 4 } },
                { { 5, 6 }, { 7, 8 } },
                { { 9, 10 }, { 11, 12 } }
            };
            foreach (int elemento in matriz3D)
            {
                Console.Write($"\t{elemento}");
            }
            Console.WriteLine();

            /* explicação do array 3d em palavras simples sem código
            ---------------------------------------------------------------
            Um array tridimensional (3D) é como uma caixa que tem comprimento, largura e altura.
            Imagine uma caixa de sapatos que você pode dividir em várias camadas (altura), e cada camada pode ser dividida em linhas (largura) e colunas (comprimento).
            Cada posição dentro dessa caixa pode ser acessada usando três números: um para a camada, um para a linha e outro para a coluna. Por exemplo, matriz3D[0, 1, 1] acessa o número 4, que está na primeira camada (0), segunda linha (1) e segunda coluna (1).
           
            No exemplo acima, temos uma matriz 3D chamada matriz3D que tem 3 camadas, cada camada tem 2 linhas e cada linha tem 2 colunas. Os números dentro da matriz representam os valores
            armazenados em cada posição da caixa tridimensional.
            
            */


            // ----------------------- FIM DE APP ------------------------

            Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair...");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");

        }
    }
}

