using IJDEVLibrary;
using IJDEVLibrary.LogsHandler;
using System.Reflection;
using System.Text;


namespace LearningCsharp;

public class ReflectionUsageDemo
{
    public ReflectionUsageDemo() { }

    public void StringBuilderDemo()
    {
        Type type = typeof(StringBuilder);
        Console.WriteLine($"Type Name: {type.Name}");
        Console.WriteLine($"Namespace: {type.Namespace}");
        Console.WriteLine($"Is Class: {type.IsClass}");
        Console.WriteLine($"Is Auto Class: {type.IsAutoClass}");
        Console.WriteLine($"Is Abstract Class: {type.IsAbstract}");
        Console.WriteLine($"Base Type: {type.BaseType}");

        Console.WriteLine("\nMethods:");
        var methods = type.GetMethods();
        int counter = 0;
        foreach (var method in methods)
        {
            counter++;
            Console.WriteLine($"{counter} -> {method.Name}");
        }

        Console.WriteLine("\nShowing Properties of the class <ReflectionUsageDemo> ");
        var properties = type.GetProperties();
        counter = 0;
        foreach (var prop in properties)
        {
            counter++;
            Console.WriteLine($"{counter} -> {prop.Name}");
        }

        Console.WriteLine("\n Showing Fields of the class <ReflectionUsageDemo> ");
        var fields = type.GetFields();
        counter = 0;
        foreach (var field in fields)
        {
            counter++;
            Console.WriteLine($"{counter} -> {field.Name}");
        }
    }

    public class PersonExample
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Greet()
        {
            Console.WriteLine($"\n Hello, my name is {Name} and I am {Age} years old.");
        }
    }

    public static void MainRUD(string[] args)
    {

        #region block code 1 --------- START OF APP ----------------------

        // Instance section
        // In this section, you can instantiate all the classes you will use in the application.
        JCustomLogger logger = new("ReflectionUsageDemo");
        AppInputOutputManager iom = new();

        // Value definition for Constants and fields section
        var info = "LEARNING REFLECTION IN C#";
        var summary = "This App attempts to show how we can use concepts of Reflection in .NET";
        char lineShape = '*';
        int lineLen = 0;
        int vspace = 2;
        int hspace = 0;
        bool useTab = false;

        // Instance member call section
        iom.ShowAppInfo(title: info, summary: summary);

        #endregion // --- starting app region ends here ---


        #region block code 2 --------- THE LOGIC OF APP GOES HERE --------

        logger.Info("Application starting...");

        // CLOCK 1: Testing PersonExample Class
        logger.Info("BLOCK 1: Testing Custom class: PersonExample");

        // Obtain type
        Type _type = typeof(PersonExample);

        // Create instance dynamically
        object obj = Activator.CreateInstance(_type);

        // Define values for my properties through Reflection
        PropertyInfo prop1 = _type.GetProperty("Name");
        PropertyInfo prop2 = _type.GetProperty("Age");
        prop1.SetValue(obj, "Cristiano Ronaldo, The GOAT");
        prop2.SetValue(obj, 40);

        // Invoke a method via Reflection
        MethodInfo method = _type.GetMethod("Greet");
        method.Invoke(obj, null);


        // BLOCK 2: Testing build-in class: StringBuilder
        logger.Info("BLOCK 2: Testing build-in class: StringBuilder");
        ReflectionUsageDemo demo = new();
        demo.StringBuilderDemo();

        #endregion // --- the logic of app region ends here ---


        #region block code 3 --------- END OF APP ------------------------

        iom.ShowAppEndInfo();

        #endregion // --- closing region ends here ---

    }
}
