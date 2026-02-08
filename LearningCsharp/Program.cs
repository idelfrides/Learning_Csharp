using IJDEVLibrary;
using System.Data;
using System.Text;

namespace LearningCsharp
{
    public class Program
    {
        public static void Main001(string[] args)
        {
            #region bloco introdução: ------------- INICIO APP ----------------
            Console.WriteLine($"\n\nHello, World!{Environment.NewLine}Eu sou o IJDEV PRO. Este é o meu app em C#!");

            var infos = "ESTUDANDO .NET E C# EM DEZEMBRO DE 2025!\n\tNAMESPACE: LearningCsharp\n\tMAIN CLASS: Program\n\tAUXILIAR CLASS: ";

            AppInputOutputManager ijlibs = new AppInputOutputManager();

            char lineShape = '=';
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);
            #endregion

            #region bloco de comentários de documentação
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

            #endregion

            #region Atribuição de valores na Declaração de variáveis em C#
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

            #endregion

            #region Declaração SEM atribuir valores ás variáveis em C#
            float numeroFloat;
            decimal numeroDecimal;
            double numeroGrande;
            bool booleanFalse;
            string outroTexto;
            #endregion

            #region atribuir valores às variáveis após a declaração da mesmas
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
            #endregion

            #region apresentação de valores em console
            Console.WriteLine("\t número é: " + numero);
            Console.WriteLine("\t número decimal é: " + decimalNumero);
            Console.WriteLine("\t texto é: " + texto);
            Console.WriteLine("\t número grande é: " + numeroGrande);
            Console.WriteLine("\t valor booleano é: " + booleano);
            Console.WriteLine("\t valor booleano falso é: " + booleanFalse);
            Console.WriteLine("\t outro texto é: " + outroTexto);
            Console.WriteLine("\t float sem f NO FINAL NÃO é PERMITIDO PELO COMPILADOR DO .NET:  " + numeroFloat);
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
            #endregion

            #region bloco de varias aulas 
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

            string autorName = "IDELFRIDES JORGE FERNANDES PAPAI";

            // if em C#
            Console.WriteLine("\n\t Exemplo de uso do if em C#:\n\n");

            var inputNome = ijlibs.InputContentHandler("Seu NOME", autorName);

            var currentDatetime = DateTime.Now;

            Console.WriteLine("\n\tOlá, " + inputNome + "!\n\tSeja bem-vindo(a) ao meu app em C#!");
            Console.WriteLine("\tHoje é " + currentDatetime.ToString("dd/MM/yyyy") + " e agora são " + currentDatetime.ToString("HH:mm:ss")
            );

            int idade;
            int idade2;

            try
            {
                var inputIdade = ijlibs.InputContentHandler("Sua IDADE", "36");
                idade = Convert.ToInt32(inputIdade);
                int.TryParse(inputIdade, out idade2);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong. ---> {e.Message}");
                idade = 0;
                idade2 = 0;
                throw new DataException("\n\n\n IDADE INFORMA INCORRETA!!!!\n\n\n");
            }
            // var inputIdade = Console.ReadLine() ?? "20";

            // Console.WriteLine(typeof(inputIdade)); // string
            Console.WriteLine($"\n\t {inputNome}, Sua idade é: {idade}");
            Console.WriteLine($"\n\t {inputNome}, Sua idade2 é: {idade2}");

            if (idade >= 18)
            {
                Console.WriteLine("\t Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("\t Você é menor de idade.");
            }

            //Console.Write("\n\n\t Digite seu PAÍS DE NASCIMENTO ::>>  ");

            var inputPais = ijlibs.InputContentHandler("Seu PAÍS DE NASCIMENTO", "Brasil");

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
                case "BRASIL" or "BRAZIL" or "BR" or "BRA":
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

            var defaultCounter = ijlibs.GetRandomIntValue(10, 1).ToString();
            var userInputProcessed = "userInputProcessed"; 

            // uso de while em C#
            Console.Write("\n=====================================\n\n");
            Console.WriteLine("Exemplo de uso do WHILE em C#:");
            Console.Write("\n=====================================\n\n");


            var promptForInput = $"NÚMERO MAXIMO DA CONTAGEM ( WHILE )::>>  (padrão é {defaultCounter}) ";
            userInputProcessed = ijlibs.InputContentHandler(promptForInput, defaultCounter);
            int maximoContagem = Convert.ToInt32(userInputProcessed);

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

            promptForInput = "NÚMERO MAXIMO DA CONTAGEM ( FOR ) ::>>  ";
            userInputProcessed = ijlibs.InputContentHandler(promptForInput, defaultCounter);
            int maximoContagemFor = Convert.ToInt32(userInputProcessed);

            for (int i = 1; i <= maximoContagemFor; i++)
            {
                Console.WriteLine($"\t Contador FOR é: {i}");
            }

            // USO DO DO...WHILE EM C#
            Console.Write("\n=====================================\n\n");
            Console.WriteLine("Exemplo de uso do DO...WHILE em C#:");
            Console.Write("\n=====================================\n\n");

            promptForInput = "NÚMERO MAXIMO DA CONTAGEM ( DO...WHILE ) ::>>  ";
            userInputProcessed = ijlibs.InputContentHandler(promptForInput, defaultCounter);
            int maximoContagemDoWhile = Convert.ToInt32(userInputProcessed);
            int contadorDoWhile = 1;

            do
            {
                Console.WriteLine($"\t Contador DO...WHILE é: {contadorDoWhile}");
                contadorDoWhile++;
            } while (contadorDoWhile <= maximoContagemDoWhile);

            #endregion

            #region estudando e testando constante em C# (C-Sharp ) 
            Console.Write("\n================================================\n\n");
            Console.Write("Estudando e testando constante em C# (C-Sharp)");
            Console.Write("\n\n=================================================\n\n");

            // Console.WriteLine("A seguir digite um valor (textual e em seguida numérico) para constantes do seu endereço resumido ... ");
            // Console.Write("Digite o nome da sua rua aqui ::>>  ");
            // string inputValue = Console.ReadLine() ?? string.Empty;
            // const var varConst = inputValue;

            const string constAutor = "IDELFRIDES JORGE FERNANDES PAPAI";
            // const string constAutor;  // uma constante em C# requer atribuição de valor a ela no momento de declaração. erro CS0145
            const string strNname = "strNname";
            var varNname = "varNname";
            // constAutor = strNname;  // não é permitido. erro CS0131
            // constAutor = varNname;  // não é permitido. erro CS0131

            const string streetName = "RUA INACIO DE ARAUJO";
            const int houseNumber = 20;

            Console.WriteLine($"NOME DO AUTOR: {constAutor}");
            Console.WriteLine($"NOME DA RUA É: {streetName}");
            Console.WriteLine($"NÚMERO DE CASA É: {houseNumber}");
            #endregion

            #region INTERPOLAÇÃO DE INTRING EM C# 
            Console.Write("\n================================================\n\n");
            Console.Write("Estudando e testando INTERPOLAÇÃO DE INTRING EM C# (C-Sharp)");
            Console.Write("\n\n=================================================\n\n");


            // Console.WriteLine($"inputNome GetType --> {inputNome.GetType}");
            // TODO 1: Como saber o tipo de um dado vindo do console em C# ?
            // TODO 2: criar uma classe gerenciador de menu e de dados de entrada
            // TODO 3: criar um projeto/app calculadora para treinar


            /*
                MANEIRAS:
                1- string.Format
                2- $ "{...}"
                3- Concatenação
                    3.1- Operador "+"  
                    3.2- string.Concat
                    3.3- string.Builder
            */
            var tipoInterpolacao = "string.Format";
            Console.WriteLine(string.Format("Tipo interpolação é -> {0}", tipoInterpolacao));

            tipoInterpolacao = "$'{ ... }'";
            Console.WriteLine($"Tipo interpolação é -> {tipoInterpolacao}");

            tipoInterpolacao = "Concatenação: Operador '+'";
            Console.WriteLine("Tipo interpolação é -> " + tipoInterpolacao);

            tipoInterpolacao = "Concatenação: string.Concat";
            Console.WriteLine(
                string.Concat("Tipo interpolação é -> ", tipoInterpolacao));

            /* 
                UTILIZAÇÃO DE tringBuilder em sistemas reais

                StringBuilder é mias indicado para trabalhar com 
                - textos extremamente grandes, 
                - arquivos com milhões de linhas 
                - é o tipo nativo do C# e por isso mesmo é mais performático e recomendado para situções listadas acima
            */
            tipoInterpolacao = "Concatenação: StringBuilder";
            StringBuilder myStrBuilder = new StringBuilder();
            myStrBuilder.Append("OLÁ! ");
            myStrBuilder.Append(inputNome);
            myStrBuilder.Append("\nÉ UMA HONRA TE VER AQUI.  ");
            myStrBuilder.Append("\nTipo interpolação é -> ");
            myStrBuilder.Append(tipoInterpolacao);

            Console.WriteLine(myStrBuilder.ToString());
            #endregion

            #region Type Casting : Implicit Casting, Explicit Casting
            infos = """
            C# Type Casting
            Type casting is when you assign a value of one data type to another type.

            In C#, there are two types of casting:

            >> Implicit Casting (automatically) - converting a smaller type to a larger type size
            char -> int -> long -> float -> double

            >> Explicit Casting (manually) - converting a larger type to a smaller size type
            double -> float -> long -> int -> char
            """;

            ijlibs.ShowPrettyInfo(infos, lineShape, 60);

            // IMPLICIT CASTING:  smaller type to a larger type 
            int myIntV = 7;
            float myFV = myIntV;         // Automatic casting: int to float
            double myDV = myFV;          // Automatic casting: float to double

            Console.WriteLine($"ORIGINAL INT VALUE IS {myIntV}");
            Console.WriteLine($"Automatic casting: int to float  {myFV}");
            Console.WriteLine($"Automatic casting: float to double  {myDV}");

            // EXPLICIT CASTING: larger type to a smaller size
            double myD2 = 789.59;
            float myFV2 = (float)myD2;     // Manual casting: double to float
            int myInt2 = (int)myFV2;       // Manual casting: float to int

            Console.WriteLine($"ORIGINAL double VALUE IS {myD2}");
            Console.WriteLine($"Explicit casting: double to float  {myFV2}");
            Console.WriteLine($"Explicit casting: float to int {myInt2}");

            // Console.WriteLine(myD2);       // Outputs 98.75
            // Console.WriteLine(myInt2);     // Outputs 98

            Console.Write("Informe sua idade (uso de  int.TryParse) ::>>    ");
            // int.TryParse(myD2, out int idade);
            int.TryParse(Console.ReadLine(), out int fieldIdade);

            // operador ternário
            fieldIdade = fieldIdade >= 18 ? fieldIdade : 0;

            Console.WriteLine($"IDADE INFORMADA É  {fieldIdade}");

            infos = "FAZENDO ESTA ALTERAÇÃO POR MEIO DO IDE VISUAL STUDIO COMMUNITY 2026";
            ijlibs.ShowPrettyInfo(infos, lineShape, 67);

            #endregion

            #region bloco ---------------- FIM DE APP --------------------
      
            ijlibs.ShowAppEndInfo();

            #endregion

        }
    }
}

