/*
  
------------------ METHOD RETURNING VALUE TECHNIQUES  --------------------

🚀 INTRODUCTION

     In C#, a method can’t literally return “different types” at runtime 
(like sometimes a string, sometimes an int) 
unless you use a very loose type like object or dynamic. But there are cleaner, 
type-safe ways to return multiple values. Let me show you the main approaches:
     

🚀 TECHNIQUES LIST

  🔹 1. Return a Tuple
Tuples are lightweight containers for multiple values.

  🔹 2. Use an out parameter
You can return one value normally and pass another via out.

  🔹 3. Create a custom class or struct or record
Custom classes or structs can encapsulate multiple values and provide a clear structure.
Best for readability and when values belong together.

  🔹 4. Return object or dynamic (not recommended)
You can return different types, but it’s unsafe and error-prone


📌 Best Practice
- Use tuples for quick multi-value returns.
- Use a custom class/record when values are conceptually related.
- Avoid object/dynamic unless you really need flexibility

--------------------------------------------------------------


using Microsoft.Extensions.Logging;

internal partial class Program
{
    static void Main(string[] args)
    {
        using ILoggerFactory factory = LoggerFactory.Create(builder => builder.AddConsole());
        ILogger logger = factory.CreateLogger("Program");
        LogStartupMessage(logger, "fun");
    }

    [LoggerMessage(Level = LogLevel.Information, Message = "Hello World! Logging is {Description}.")]
    static partial void LogStartupMessage(ILogger logger, string description);
}

*/


using IJDEVLibrary;
using static LearningCsharp.ReturnValueTechniques.DemonstrateTechniques;
//using static LearningCsharp;


namespace LearningCsharp
{
    public class ReturnValueTechniques
    {
        //public ReturnValueTechniques() { }

        public class DemonstrateTechniques()
        {
            // 1.1 Using Tuples: with unnamed elements
            public (int, string) GetTuple()
            {
                return (42, "The answer");
            }

            // 1.2 Using Tuples: with named elements
            public (int sum, double average, double median, double mean, double standardDeviation, int count, int min, int max) GetNamedTuple(int[] numbers)
            {
                // Calculate statistics (dummy values for illustration)
                int sum = numbers.Sum();
                double average = numbers.Average();
                double median = MathUtils.Median(numbers);
                double standardDeviation = MathUtils.StandardDeviation(numbers);
                int count = numbers.Count();
                int min = numbers.Min();
                int max = numbers.Max();
                double mean = sum / count;

                return (sum, average, median, mean, standardDeviation, count, min, max);
            }

            // 2. Using Out Parameters
            public int GetOutParams(int number01, int number02, out int remainder)
            {
                remainder = number01 % number02;
                return number01 / number02;
            }

            // 3.1 Using a Custom record Class
            public record CalculateResultCustomClass(int sum, double avg, double median, double standardDeviation);

            public CalculateResultCustomClass GetCalculate(int[] values)
            {
                int sum = values.Sum();
                double avg = values.Average();
                double median = MathUtils.Median(values);
                double standardDeviation = MathUtils.StandardDeviation(values);

                return new CalculateResultCustomClass(sum, avg, median, standardDeviation);
            }

            // 3.2 Using a Custom Enum
            public enum OperationStatus
            {
                Success,
                Failure,
                Pending
            }
            public OperationStatus PerformEnumOperation(bool succeed)
            {
                return succeed ? OperationStatus.Success : OperationStatus.Failure;
            }

            // 3.3 Using a Custom class
            public class OperationResult
            {
                public bool IsSuccessful { get; protected set; }
                public string Message { get; protected set; }
                public OperationResult(bool isSuccessful, string message)
                {
                    IsSuccessful = isSuccessful;
                    Message = message;
                }
            }
            public OperationResult ExecuteClassOperation(bool succeed)
            {
                if (succeed)
                {
                    return new OperationResult(true, "Operation completed successfully.");
                }
                else
                {
                    return new OperationResult(false, "Operation failed.");
                }
            }


            // 4. Using Object (not recommended)
            public object GetObjectByType(string? returnType=null)
            {
                // Returning a value basing on returnType for demonstration; could be any type below
                bool randomBool = new Random().Next(0, 2) == 0;
                bool randomBool1 = new Random().Next(0, 2) == 1;
                
                switch (returnType)
                {
                    case "int": return 100;
                    case "double": return 99.99;
                    case "string": return "This is a string result";
                    case "bool": return randomBool1;
                    case "list": return new List<int> { 1, 2, 3, 4, 5 };
                    case "custom record": return GetCalculate(new int[] { 10, 2, 5, 2, 5, 1, 5 });
                    case "enum": return PerformEnumOperation(randomBool);
                    case "custom class": return ExecuteClassOperation(randomBool);
                    case "class": return new OperationResult(randomBool1, $"Operation executed via object return with value={randomBool1}");
                    case "tuple": return (1, "Tuple Result");
                    case "float": return 3.14f;
                    case "char": return 'A';
                    case "datetime": return DateTime.Now;
                    case "array": return new int[] { 10, 20, 30 };
                    case "dictionary": return new Dictionary<string, int> { { "One", 1 }, { "Two", 2 }, { "Three", 3 } };
                    case "decimal": return 123.45m;
                    case "default": return "Default value is related to type null";
                    default: return "This is the response for null type";
                }
            }
        }

        public static void Main(string[] args)
        {

            #region bloco ------------------ START OF APP ----------------------
            AppInputOutputManager iom = new AppInputOutputManager();

            var infos = "LEARNING CSHARP PROJECT: class ReturnValueTechniques";
            char lineShape = '*';

            iom.ShowAppInfo(
                title: infos,
                summary: "This App atemp to show to we cam return values using different techniques."
            );
            #endregion

            #region bloco ------------------ RETURN VALUE TECHNIQUES DEMONSTRATION GOES HERE -----------------------

            DemonstrateTechniques dt = new();

            infos = "METHOD RETURNING VALUE TECHNIQUES DEMONSTRATION";
            iom.ShowPrettyInfo(infos, lineShape: lineShape, lineLen: infos.Length + 10);

            // 1.1 Using Tuples: with unnamed elements
            Console.WriteLine("\n1.1 Using Tuples: with unnamed elements");
            var tupleResult = dt.GetTuple();
            Console.WriteLine($"Tuple Result: Item1={tupleResult.Item1}, Item2={tupleResult.Item2}");

            // 1.2 Using Tuples: with named elements
            Console.WriteLine("\n1.2 Using Tuples: with named elements");
            var namedTupleResult = dt.GetNamedTuple(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"Named Tuple Result: " +
                $"Sum={namedTupleResult.sum}, Average={namedTupleResult.average}, " +
                $"Median={namedTupleResult.median}, Mean={namedTupleResult.mean}, " +
                $"Standard Deviation={namedTupleResult.standardDeviation}"
            );

            // 2. Using Out Parameters
            Console.WriteLine("\n2. Using Out Parameters");
            // --->  this way in older C# versions:
            //int outRemainder;
            //int divideResult = dt.GetOutParams(7, 3, out outRemainder);

            // ---> or more concisely in C# 7.0 and later:
            int divideResult = dt.GetOutParams(7, 3, out int outRemainder);
            Console.WriteLine($"Out Params Result: Division Result={divideResult} | Remainder={outRemainder}");

            // 3.1 Using a Custom method with record class return type
            Console.WriteLine("\n3.1 Using a Custom method with record class return type");
            var customResult = dt.GetCalculate(new int[] { 1, 2, 3, 4, 5 });
            Console.WriteLine($"\nCustom Class Result: " +
                $"Sum={customResult.sum}, Average={customResult.avg}, " +
                $"Median={customResult.median}, " +
                $"Standard Deviation={customResult.standardDeviation}"
            );

            // 3.2 Using a Custom Enum
            Console.WriteLine("\n3.2 Using a Custom Enum");
            var operationStatusTrue = dt.PerformEnumOperation(true);
            Console.WriteLine($"\nOperation Status: {operationStatusTrue}");

            var operationStatusFalse = dt.PerformEnumOperation(false);
            Console.WriteLine($"\nOperation Status: {operationStatusFalse}");

            // 3.3 Using a Custom method with class return type
            Console.WriteLine("\n3.3 Using a Custom method with class return type");
            var operationResultSuccess = dt.ExecuteClassOperation(true);
            Console.WriteLine($"\nOperation Result: Success={operationResultSuccess.IsSuccessful}, Message='{operationResultSuccess.Message}'");
            var operationResultFailure = dt.ExecuteClassOperation(false);
            Console.WriteLine($"\nOperation Result: Success={operationResultFailure.IsSuccessful}, Message='{operationResultFailure.Message}'");

            // ----------------------------------------------------------------
            // 4. Using Object (not recommended)
            // ----------------------------------------------------------------
            infos = "4. Using Object just for test (not recommended)";
            iom.ShowPrettyInfo(infos, lineShape, 70);

            object objectResult;

            objectResult = dt.GetObjectByType("string");
            string normalizeValueStr = (string)objectResult;
            Console.WriteLine($"\nObject Result (string): {normalizeValueStr}");

            objectResult = dt.GetObjectByType("int");
            var normalizeValueInt = (int)objectResult;
            Console.WriteLine($"\nObject Result (int): {normalizeValueInt}");

            objectResult = dt.GetObjectByType("custom record");
            Console.WriteLine($"\nObject Result (custom record): {objectResult}");

            objectResult = dt.GetObjectByType("enum");
            Console.WriteLine($"\nObject Result (enum): {objectResult}");

            objectResult = dt.GetObjectByType("custom class");
            OperationResult classResult = (OperationResult)objectResult;   
            Console.WriteLine($"\nOperation Result (custom class): Success={classResult.IsSuccessful}, Message='{classResult.Message}'");

            objectResult = dt.GetObjectByType("class");
            if (objectResult is OperationResult safeClass)
            {
                Console.WriteLine("\n Object Result (class - 'is' cast)");
                Console.WriteLine($"\n Operation Result (class): Success={safeClass.IsSuccessful}, Message='{safeClass.Message}'");
            }

            objectResult = dt.GetObjectByType("tuple");
            Console.WriteLine($"\nObject Result (tuple): {objectResult}");

            // do not work 
            // objectResult = dt.GetObjectByType("list");
            // List<int> listValue = (List<int>)objectResult;
            // Console.WriteLine($"\nObject Result (list): {listValue}");

            // pattern matching with 'is' operator for LIST safe casting:
            objectResult = dt.GetObjectByType("list");
            if (objectResult is List<int> safeList)
            {
                Console.WriteLine("\n Object Result (List - 'is' cast)");
                iom.ProcessCollections(inputCollection: safeList, orientation: "horizontal");
            }

            objectResult = dt.GetObjectByType("datetime");
            Console.WriteLine($"\nObject Result (datetime): {objectResult}");

            // Do not work in this way
            // objectResult = dt.GetObjectByType("array");
            // var arrayValue = (int[])objectResult;
            // Console.WriteLine($"\nObject Result (array): {arrayValue}");

            /* Do notwork with this way because of the risk of InvalidCastException 
             * if the type is not correct, better use pattern matching with 'is' or 'as' operators:
             * --------
            object objectResultDict = dt.GetObjectByType("dictionary");
            var dictValue = (Dictionary<string, int>)objectResultDict;
            Console.WriteLine($"\nObject Result (dictionary): {dictValue}");
            */

            // pattern matching with 'is' operator for safe casting:
            object objectResultDict = dt.GetObjectByType("dictionary");

            if (objectResultDict is Dictionary<string, int> safeDict)
            {
                Console.WriteLine("\n Object Result (dictionary - 'is' cast) WITH METHOD <ProcessCollections>");
                iom.ProcessCollections(inputCollection: safeDict, showIndex: false);
                Console.WriteLine("\n Object Result (dictionary - 'is' cast) WITH METHOD <ProcessDicionaryInt> ");
                iom.ProcessDicionaryInt(safeDict);
            }

            // pattern matching with 'as' operator for safe casting:
            // objectResultDict = dt.GetObjectByType("dictionary");
            // var dictValueAs = objectResultDict as Dictionary<string, int>;
            // Console.WriteLine($"\nObject Result (dictionary - 'as' cast): {dictValueAs}");

            // pattern matching with 'is' operator for array safe casting:
            objectResult = dt.GetObjectByType("array");

            if (objectResult is Array safeArray)
            {
                Console.WriteLine("\n Object Result (array - 'is' cast)");
                //iom.ProcessCollections(inputCollection: safeArray, showIndex: false, orientation: "horizontal");
                foreach (var item in safeArray)
                {
                    Console.WriteLine($"Item: {item}");
                }
            }

            objectResult = dt.GetObjectByType("decimal");
            Console.WriteLine($"\nObject Result (decimal): {objectResult}");

            objectResult = dt.GetObjectByType("float");
            Console.WriteLine($"\nObject Result (float): {objectResult}");

            objectResult = dt.GetObjectByType("char");
            Console.WriteLine($"\nObject Result (char): {objectResult}");

            objectResult = dt.GetObjectByType("double");
            Console.WriteLine($"\nObject Result (double): {objectResult}");

            objectResult = dt.GetObjectByType("bool");
            Console.WriteLine($"\nObject Result (bool): {objectResult}");

            objectResult = dt.GetObjectByType("default");
            Console.WriteLine($"\nObject Result (default): {objectResult}");

            objectResult = dt.GetObjectByType();
            Console.WriteLine($"\nObject Result (null): {objectResult}");

            #endregion

            #region bloco ------------------ Conclusion: END OF APP --------------------

            iom.ShowAppEndInfo();

            #endregion
        }
    }
}
