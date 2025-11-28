namespace LearningCsharp
{   
    public class Program
    {   
        public static void Main01(string[] args)
        {
            Console.WriteLine($"\n\nHello, World!{Environment.NewLine}Eu sou o IJDEV PRO. Este é o meu app em C#!");

            Console.Write("\n===================================================\n\n");
            Console.WriteLine(
                "[AULA 6 - 9: VARIÁVEIS]: Tipos e Declaração de variáveis");
            Console.Write("\n===================================================\n\n");

            /*
            bool - 1 bit, valores true ou false
            byte - 8 bits, valores de 0 a 255 é util
            sbyte - 8 bits, valores de -128 a 127
            short - 16 bits, valores de -32.768 a 32.767
            char - 16 bits, representa um único caractere Unicode
            int - 32 bits, valores de -2.147.483.648 a 2.147.483.647
            float - 32 bits, precisão simples, usado para números decimais
            long - 64 bits, valores de -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            double - 64 bits, precisão dupla, usado para números decimais com maior precisão
            var - tipo implícito, o compilador infere o tipo com base no valor atribuído
            string - uma sequência de caracteres Unicode
            decimal - 128 bits, usado para valores monetários e alta precisão
            object - tipo base para todos os tipos em C#
            */

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

            // Atribuição de valores na Declaração de variáveis em C#
            short numeroShort = 25;
            int numero = 10;
            float decimalNumero = 20.598f;
            string texto = "Este é um texto em C#";
            bool booleano = true;
            var numeroVar = 100; // O compilador infere o tipo da variável de acordo com o valor atribuído
            var textoVar = "BRASIL";
            char caractere = 'I'; // Exemplo de variável do tipo char que representa um único caractere
            char numericoConvertido = (char)65; // Atribuição de valor numérico convertido para char (representa 'A')
            char caractereSimbolo = '#'; // Exemplo de variável do tipo char com um símbolo
            // char variavelChar = "P"; // Isso causará um erro de compilação, pois aspas duplas são usadas para strings, não para char

            byte byteNumero = 255; // Exemplo de variável do tipo byte
            long numeroLongo = 12345678901234L;
            object objetoQualquer = "Eu sou um objeto em C#";
            object numeroComoObjeto = 500;
            object booleanoComoObjeto = false;
            object caractereComoObjeto = 'C';
            object decimalComoObjeto = 99.99m;
            object floatComoObjeto = 123.45f;


            // Declaração SEM atribuir valores ás variáveis em C#
            float numeroFloat;
            decimal numeroDecimal;
            double numeroGrande;
            bool booleanFalse;
            string outroTexto;

            numeroFloat = 98.77f;
            numeroGrande = 123456789.12345;
            booleanFalse = false;
            outroTexto = "Outro texto em C# que não foi atribuído na declaração";
            numeroDecimal = 1000.50m; // O sufixo 'm' indica que é um valor decimal
            // decimal decimalSemf = 500.75; // Isso causará um erro de compilação, pois o sufixo 'f' é obrigatório para float

            // System.String mensagem = "Mensagem usando o namespace System"; // System.String é equivalente a string em C#
            // string saudacao = "Olá, Mundo!";

            // Int32 numeroInt32 = 42; // Int32 é um alias para o tipo int em C#
            // int inteiro = numeroInt32; // Atribuição de Int32 a int


            Console.WriteLine("\t número é: " + numero);
            Console.WriteLine("\t número decimal é: " + decimalNumero);
            Console.WriteLine("\t texto é: " + texto);
            Console.WriteLine("\t número grande é: " + numeroGrande);
            Console.WriteLine("\t valor booleano é: " + booleano);
            Console.WriteLine("\t valor booleano falso é: " + booleanFalse);
            Console.WriteLine("\t outro texto é: " + outroTexto);
            Console.WriteLine("\t decimal/float sem f NO FINAL NÃO é PERMITIDO PELO COMPILADOR DO .NET:  " + numeroFloat);
            Console.WriteLine("\t número com var é: " + numeroVar);
            Console.WriteLine("\t texto com var é: " + textoVar);
            Console.WriteLine("\t caractere é: " + caractere);
            Console.WriteLine("\t número do tipo byte é: " + byteNumero);
            Console.WriteLine("\t número longo do tipo long é: " + numeroLongo);
            Console.WriteLine("\t Número short: " + numeroShort);
            Console.WriteLine("\t Número decimal do tipo decimal: " + numeroDecimal);
            Console.WriteLine("\t Caractere convertido de número 65 para char é: " + numericoConvertido);
            Console.WriteLine("\t Caractere símbolo é: " + caractereSimbolo);
            Console.WriteLine("\t Objeto qualquer é: " + objetoQualquer);
            Console.WriteLine("\t Número como objeto é: " + numeroComoObjeto);
            Console.WriteLine("\t Booleano como objeto é: " + booleanoComoObjeto);
            Console.WriteLine("\t Caractere como objeto é: " + caractereComoObjeto);
            Console.WriteLine("\t Decimal como objeto é: " + decimalComoObjeto);
            Console.WriteLine("\t Float como objeto é: " + floatComoObjeto);

            Console.WriteLine("\n\t ===== CONVERSÕES DE TIPOS DE VARIÁVEIS EM C# =====");
            
            // parse : converter string para int ou para o tipo desejado
            Console.WriteLine("\n\t ******* CONVERTENDO DE STRING PARA INT *******");
            string numeroString = "957";
            int numeroParte = int.Parse(numeroString);
            Console.WriteLine("\t Número convertido de <string> para <int> utilizando o metodo Parse() é: " + numeroParte); 

            // usando Convert : converter string para int, double, float, long, decimal
            Console.WriteLine("\n\t ******* CONVERTENDO DE STRING PARA OUTROS TIPOS *******");        
            int numeroConvertido = Convert.ToInt32("850");
            double doubleConvertido = Convert.ToDouble("12345.67");
            float floatConvertido = Convert.ToSingle("345.67");

            Console.WriteLine("\t convertido de <string> para <int> usando Convert.ToInt32() é: " + numeroConvertido);
            Console.WriteLine("\t convertido de <string> para <double> usando Convert.ToDouble() é: " + doubleConvertido);
            Console.WriteLine("\t convertido de <string> para <float> usando Convert.ToSingle() é: " + floatConvertido);
            Console.WriteLine("\t convertido de <string> para <long> usando Convert.ToInt64() é: " + Convert.ToInt64("9876543210"));
            Console.WriteLine("\t convertido de <string> para <decimal> usando Convert.ToDecimal() é: " + Convert.ToDecimal("7567.29"));

            Console.WriteLine("\n\t ******* CONVERTENDO DE INT PARA STRING *******");
            // ToString : converter int para string
            int numeroParaConverter = 200;
            // string numeroConvertidoParaString = numeroParaConverter.ToString();
            // string numeroConvertidoParaString = int.ToString(200); // Outra forma de usar ToString
            Console.WriteLine("\t convertido de <int> para <string> usando ToString() é: " + numeroParaConverter.ToString());


            // AULA 18 - OPERADOREES LOGICOS E DE COMPARAÇÃO
            Console.Write("\n===================================================\n\n");
            Console.WriteLine("AULA 18 - OPERADOREES LOGICOS E DE COMPARAÇÃO");
            Console.Write("\n===================================================\n\n");

            // Operadores logicos: && (E), || (OU), ! (NÃO)
            int a = 10;
            int b = 20; 
            bool resultadoE = (a < b) && (b > 15); // true && true -> true
            bool resultadoOu = (a > b) || (b > 15); // false || true -> true
            bool resultadoNao = !(a > b); // !(false) -> true    

            // Operadores de comparação: 
            // IGUAL : ==
            // DIFERENTE : !=
            // MAIOR : >
            // MENOR : <
            // MAIOR OU IGUAL : >=
            // MENOR OU IGUAL : <=  

            bool igual = (a == b); // false
            bool diferente = (a != b); // true
            bool maior = (b > a); // true
            bool menor = (a < b); // true
            bool maiorOuIgual = (b >= 20); // true
            bool menorOuIgual = (a <= 10); // true

            Console.WriteLine("\t Resultados dos operadores lógicos e de comparação:\n\n");
            Console.WriteLine($"\t Resultado do operador E (&&): {resultadoE}");
            Console.WriteLine($"\t Resultado do operador OU (||): {resultadoOu}"); 
            Console.WriteLine($"\t Resultado do operador NÃO (!): {resultadoNao}");
            Console.WriteLine($"\t Resultado do operador IGUAL (==): {igual}");
            Console.WriteLine($"\t Resultado do operador DIFERENTE (!=): {diferente}");
            Console.WriteLine($"\t Resultado do operador MAIOR (>): {maior}");
            Console.WriteLine($"\t Resultado do operador MENOR (<): {menor}");
            Console.WriteLine($"\t Resultado do operador MAIOR OU IGUAL (>=): {maiorOuIgual}");
            Console.WriteLine($"\t Resultado do operador MENOR OU IGUAL (<=): {menorOuIgual}"); 

            // if em C#
            Console.WriteLine("\n\t Exemplo de uso do if em C#:\n\n");

            Console.Write("\t Digite seu NOME ::>>  ");

            var inputNome = Console.ReadLine() ?? string.Empty  ;
            var currentDatetime = DateTime.Now;

            Console.WriteLine("\n\tOlá, " + inputNome + "!\n\tSeja bem-vindo(a) ao meu app em C#!");
            Console.WriteLine("\tHoje é " + currentDatetime.ToString("dd/MM/yyyy") + " e agora são " + currentDatetime.ToString("HH:mm:ss")
            );

            Console.Write("\n\n\t Informe sua IDADE ::>>  ");
            var inputIdade = Console.ReadLine() ?? string.Empty;

            // Console.WriteLine(typeof(inputIdade)); // string
            int idade = Convert.ToInt32(inputIdade);
            Console.WriteLine($"\n\t {inputNome}, Sua idade é: {idade}");

            if (idade >= 18)
            {
                Console.WriteLine("\t Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("\t Você é menor de idade.");
            }

            Console.Write("\n\n\t Digite seu PAÍS DE NASCIMENTO ::>>  ");
            var inputPais = Console.ReadLine() ?? string.Empty;

            /*
            var country = inputPais?.Trim();
            Console.WriteLine(country.Normalize());
            Console.WriteLine(country.ToUpperInvariant());
            Console.WriteLine(country.ToLowerInvariant());
            Console.WriteLine(country.ToLower());
            Console.WriteLine(country.ToUpper);
            */

            var pais = inputPais.Trim().ToUpperInvariant();

            switch (pais)
            {
                case "GUINÉ-BISSAU":
                case "GUINE-BISSAU":
                case "GUINE BISSAU":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu na Guiné-Bissau!");
                    break;
                case "BURKINA FASO":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu em Burkina Faso!");
                    break;
                case "ESTADOS UNIDOS" or "EUA" or "USA":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu nos Estados Unidos!");
                    break;
                case "BRASIL":
                case "BRAZIL":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu no Brasil!");
                    break;
                case "CANADÁ" or "CANADA":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu no Canadá!");
                    break;
                case "PORTUGAL":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu em Portugal!");
                    break;
                case "MOÇAMBIQUE":
                case "MOCAMBIQUE":
                case "MOZAMBIQUE":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu em Moçambique!");
                    break;
                case "ANGOLA":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu em Angola!");
                    break;
                case "TIMOR-LESTE":
                case "TIMOR LESTE":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu em Timor-Leste!");
                    break;
                case "SUÍÇA" or "SUICA":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu na Suiça!");
                    break;
                case "JAPÃO" or "JAPAO":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu no Japão!");
                    break;
                case "CABO VERDE":
                case "CABO-VERDE":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu em Cabo Verde!");
                    break;
                case "SENEGAL":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu no Senegal!");
                    break;
                case "CHINA":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu na China!");
                    break;
                case "ÁFRICA DO SUL":
                case "AFRICA DO SUL":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu na África do Sul!");
                    break;
                case "HOLANDA":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu na Holanda!");
                    break;
                case "BÉLGICA":
                case "BELGICA":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu na Bélgica!");
                    break;
                case "UK":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu no Reino Unido!");
                    break;
                case "ALEMANHA":
                    Console.WriteLine($"\n\t {inputNome}, você nasceu na Alemanha!");
                    break;
                default:
                    Console.WriteLine($"\n\t {inputNome}, país não reconhecido: {inputPais}");
                    break;
            }

            // uso de while em C#
            Console.Write("\n=====================================\n\n"); 
            Console.WriteLine("Exemplo de uso do WHILE em C#:");
            Console.Write("\n=====================================\n\n");

            Console.Write("DIGITE O NÚMERO MAXIMO DA CONTAGEM ::>>  ");
            var inputContador = Console.ReadLine() ?? string.Empty; 
            int maximoContagem = Convert.ToInt32(inputContador);
           
            int contador = 1;
            while (contador <= maximoContagem)
            {
                Console.WriteLine($"\t Contador WHILE é: {contador}");
                contador++;
            }

            // uso de for em C#
            Console.Write("\n=====================================\n\n");   
            Console.WriteLine("Exemplo de uso do FOR em C#:");
            Console.Write("\n=====================================\n\n");
            
            Console.Write("DIGITE O NÚMERO MAXIMO DA CONTAGEM ::>>  ");
            
            var inputContadorFor = Console.ReadLine() ?? string.Empty;
            int maximoContagemFor = Convert.ToInt32(inputContadorFor);

            for (int i = 1; i <= maximoContagemFor; i++)
            {
                Console.WriteLine($"\t Contador FOR é: {i}");
            }

            // USO DO DO...WHILE EM C#
            Console.Write("\n=====================================\n\n");
            Console.WriteLine("Exemplo de uso do DO...WHILE em C#:");
            Console.Write("\n=====================================\n\n");
            
            Console.Write("DIGITE O MAXIMO DA CONTAGEM ::>>  ");

            var inputContadorDoWhile = Console.ReadLine() ?? string.Empty;
            int maximoContagemDoWhile = Convert.ToInt32(inputContadorDoWhile);
            int contadorDoWhile = 1;

            do
            {
                Console.WriteLine($"\t Contador DO...WHILE é: {contadorDoWhile}");
                contadorDoWhile++;
            } while (contadorDoWhile <= maximoContagemDoWhile);



            // ----------------------- FIM DE APP ------------------------

            Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair...");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");

        }
    }
}

