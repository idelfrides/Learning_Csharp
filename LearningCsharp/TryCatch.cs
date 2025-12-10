/*
-----------------------------------
C# Exceptions - Try..Catch
-----------------------------------

1 >> C# Exceptions

When executing C# code, different errors can occur: coding errors made by the programmer, errors due to wrong input, or other unforeseeable things.

When an error occurs, C# will normally stop and generate an error message. The technical term for this is: C# will throw an exception (throw an error).

2 >> C# try and catch

The try statement allows you to define a block of code to be tested for errors while it is being executed.

The catch statement allows you to define a block of code to be executed, if an error occurs in the try block.

The try and catch keywords come in pairs:

Syntax
try 
{
   Block of code to try
}
catch (Exception e)
{
   Block of code to handle errors
}

Consider the following example, where we create an array of three integers:

3 >> Finally
The finally statement lets you execute code, after try...catch, regardless of the result:

4 >> The throw keyword
The throw statement allows you to create a custom error.

The throw statement is used together with an exception class. There are many exception classes available in C#.
Some of them are: ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc:
*/


using LearningCsharp;      //include the System.IO namespace

class TryCatch
{
    
    class TryCatchMainClass
    {

        public static void Main(string[] args)
        {

            #region bloco introdução: ------------- INICIO APP ----------------
            var infos = "ESTUDANDO ERROS E EXCEÇÕES EM C#!\n\tMAIN CLASS:  TryCatchMainClass\n\tAUXILIAR CLASS: ";

            IJDEVLibs ijlibs = new IJDEVLibs();

            char lineShape = '=';
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);
            #endregion

            #region bloco da app propriamente dita

            try
            {
                int[] myNumbers = {1, 2, 3, 7, 9, 15, 87, 65, 10};
                Console.WriteLine(myNumbers[1]);
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.Message);
                // Console.WriteLine("Something went wrong.");
                Console.WriteLine($"Something went wrong. ---> {e.Message}");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished. This is finally block");
            }

            // ijlibs.CheckAge(17);   // will return error
            ijlibs.CheckAge(18);      // success
            ijlibs.CheckAge(22);      // success
            #endregion


            #region bloco ---------------- FIM DE APP --------------------
            Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair ...  ");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");
            #endregion

        }

    }
}