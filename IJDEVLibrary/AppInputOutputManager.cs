namespace IJDEVLibrary;

public class AppInputOutputManager
{
    public AppInputOutputManager()
    {
        ShowPrettyInfo("CONSTRUTOR <AppInputOutputManager>", '$', 60);
    }

    public string InputContentHandler(string prompt, string defaultValue)
    {

        BuildSpaces("vertical", 2);
        Console.Write($"\t INFORME {prompt} ::>>  ");
        var userInput = Console.ReadLine();
        var finalInput = string.IsNullOrWhiteSpace(userInput) ? defaultValue : userInput;

        Console.WriteLine($"User entered: {userInput}");
        Console.WriteLine($"Processed input result: {finalInput}");
        return finalInput;
    }
        
    public static void ShowPrettyInfo(string info, char lineShape, int lineLen, int vspace = 3, int hspace = 0, bool useTab=true)
    {
        BuildLines(lineShape, lineLen, vspace, hspace, useTab);
        Console.WriteLine($"\t{info}");
        BuildLines(lineShape, lineLen, 0, hspace, useTab);
    }

    public int[] GenerateIntValuesArray(int qtd, int maxValue, int minValue = 0)
    {
        Random rand = new Random();

        if (minValue >= maxValue)
        {
            throw new IJCustomExceptions(5, "minValue must be less than maxValue.");
        }
        int[] valuesArr = new int[qtd];
        for (int i = 0; i < qtd; i++)
        {
            valuesArr[i] = rand.Next(minValue, maxValue + 1); // Scores between 0 and maxScore
        }
        return valuesArr;
    }

    public int GetRandomIntValue(int maxValue, int minValue = 1)
    {
        Random rand = new Random();
        if (minValue >= maxValue)
        {
            throw new IJCustomExceptions(5, "minValue must be less than maxValue.");
        }
        return rand.Next(minValue, maxValue + 1); // a value between minValue and maxValue
    }

    public List<int> GenerateStudentAgesList(int numberOfStudents, int minAge, int maxAge)
    {
        Random rand = new Random();
        List<int> StudentAges = new List<int>();
        for (int i = 0; i < numberOfStudents; i++)
        {
            StudentAges.Add(rand.Next(minAge, maxAge + 1)); // Ages between minAge and maxAge
        }
        return StudentAges;
    }

    public void ProcessList(List<string> myList, bool showIndex = true)
    {

        switch (showIndex)
        {
            case true:
                for (int i = 0; i < myList.Count; i++) { Console.WriteLine($"\t{i} | {i + 1} ::>> {myList[i]}"); }
                break;
            case false:
                foreach (string item in myList) { Console.WriteLine($"\t{item}"); }
                break;
        }
    }

    public void ProcessArrays(string[] myArray, bool showIndex = true)
    {
        switch (showIndex)
        {
            case true:
                for (int i = 0; i < myArray.Length; i++) { Console.WriteLine($"\t{i} | {i + 1} ::> {myArray[i]}"); }
                break;
            case false:
                foreach (var item in myArray) { Console.WriteLine($"\t{item}\n"); }
                break;
        }
    }

    public void ProcessCollections<T>(IEnumerable<T> inputCollection, bool showIndex = false, string orientation = "vertical")
    {
        if (orientation.ToLower() == "vertical")
        {
            Console.WriteLine("\t Vertical orientation ... \n\n");
            switch (showIndex)
            {
                case true:
                    foreach (var pair in inputCollection.Select((item, index) => new { item, index }))
                    {
                        Console.WriteLine($"\t[{pair.index}] -> {pair.item}");
                    }
                    break;
                case false:
                    foreach (var item in inputCollection) Console.WriteLine($"\t{item}");
                    break;
            }
        }
        else if (orientation.ToLower() == "horizontal")
        {
            Console.WriteLine("\t Horizontal orientation ... \n\n");
            Console.Write("\t :::>>  ");

            switch (showIndex)
            {
                case true:
                    foreach (var pair in inputCollection.Select((item, index) => new { item, index }))
                    {
                        Console.Write($"[{pair.index}]:{pair.item};  ");
                    }
                    break;
                case false:
                    foreach (var item in inputCollection) Console.Write($"{item};  ");
                    break;
            }
        }
        else
        {
            throw new IJCustomExceptions(3, "Parameter value NOT FOUND -> Status 404. Parameter 'orientation' must be 'vertical' or 'horizontal'");
        }
    }

    public void ProcessDicionaryInt(Dictionary<string, int> myDict, bool showKeys = true)
    {

        switch (showKeys)
        {
            case true:
                foreach (var par in myDict) { Console.WriteLine($"\t{par.Key} => {par.Value}"); }
                break;
            case false:
                foreach (var par in myDict) { Console.WriteLine($"\tValor: {par.Value}"); }
                break;
        }
    }

    public void ProcessDicionaryStr(Dictionary<string, string> myDict, bool showKeys = true)
    {
        switch (showKeys)
        {
            case true:
                foreach (var par in myDict) { Console.WriteLine($"\t{par.Key} ::> {par.Value}"); }
                break;
            case false:
                foreach (var par in myDict) { Console.WriteLine($"\tValor: {par.Value}"); }
                break;
        }
    }

    public static void BuildLines(char lineShape, int lineLength, int vspace = 3, int hspace = 0, bool useTab=true)
    {
        if (vspace > 0)
        {
            BuildSpaces("vertical", vspace);
        }
        else if (hspace > 0)
        {
            BuildSpaces("horizontal", hspace);
        }
        string lineFormatted = new string(lineShape, lineLength);

        if(useTab == true) Console.WriteLine($"\t{lineFormatted}");
        if(useTab == false) Console.WriteLine($"{lineFormatted}");
    }

    public static void BuildSpaces(string spOrientation, int spLen)
    {
        switch (spOrientation)
        {
            case "vertical":
                string vspace = new string('\n', spLen);
                Console.Write(vspace);
                break;
            case "horizontal":
                string hspace = new string('\t', spLen);
                Console.WriteLine(hspace);
                break;
            default:
                Console.WriteLine("DEFAULT");
                break;
        }
    }

    public async Task EsperarAsync(int tempoSegundos)
    {
        Console.WriteLine($"Aguardando {tempoSegundos}s assincronamente para executar ação solicitada . . .");

        // O valor é em milissegundos
        await Task.Delay(TimeSpan.FromSeconds(tempoSegundos));

        Console.WriteLine("Pausa assíncrona com Task terminada.");
    }

    public async void CustomWait(int tempoEmMinutos)
    {

        int tempoConvertidoSegundos;
        tempoConvertidoSegundos = tempoEmMinutos * 60;   // converte minutos para segundos
        Console.WriteLine($"Pausar {tempoEmMinutos} min assincronamente antes de executar ação solicitada . . .");

        // O valor é em milissegundos
        Thread.Sleep(tempoConvertidoSegundos * 1000);

        Console.WriteLine("Pausa com Thread  Finalizada.");
    }

    public static void CheckAge(int age)
    {
        if (age < 18)
        {
            throw new ArithmeticException("Access denied - You must be at least 18 years old.");
        }
        else
        {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }

    public static void CheckAgeCustom(int age)
    {
        if (age < 18)
        {
            throw new IJCustomExceptions(1, $"Access denied - You must be at least 18 years old. AGE: {age} < 18");
        }
        else if (18 <= age & age < 25)
        {
            throw new IJCustomExceptions(2, $"IDADE PERMITIDA COM RESTRIÇÕES: IDADE '18 <= {age} < 25' ");
        }
        else
        {
            Console.WriteLine("Access granted - You are old enough!");
        }
    }

    public static void ShowAppEndInfo()
    {
        ShowPrettyInfo("\t\tEND OF THE APPLICATION", '$', 75, 3, 0, false);
        Console.Write($"{Environment.NewLine}\nPress any Key to Leave the APP . . .\n\n\n\n");

        Console.ReadKey(true);
        Environment.Exit(0);
    }

    public static void ShowAppInfo(string title, string summary)
    {
        Console.WriteLine($"\n\n=========================== {title} =========================\n");
        Console.WriteLine($"{summary}.");
        Console.WriteLine("========================================================================\n");
    }
}
