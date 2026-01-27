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


using IJDEVLibrary;
using System;
using System.IO.Compression;
namespace LearningCsharp;      //include the System.IO namespace

class TryCatch
{
    
    class TryCatchMainClass
    {

        public static void MainTC(string[] args)
        {

            #region bloco introdução: ------------- INICIO APP ----------------
            var infos = "ESTUDANDO ERROS E EXCEÇÕES EM C#!\n\tMAIN CLASS:  TryCatchMainClass\n\tAUXILIAR CLASS: ";

            IJDEVLibs ijlibs = new IJDEVLibs();

            char lineShape = '=';
            IJDEVLibs.ShowPrettyInfo(infos, lineShape, 60);
            #endregion

            #region bloco da app propriamente dita

            ijlibs.CustomWait(tempoEmMinutos: 2);

            int[] myNumbers = { 1, 11, 54, 96, 7, 2, 20, 77, 1533, 33, 15, 3, 7, 9, 15, 87, 65, 10 }; // Length 18
            Random random = new Random();

            // var itemsList = Enumerable.Range(1, 30);
            // Console.WriteLine($"itemsList: {itemsList}");
             int tempoSleepSegundos = 60;


            /*
            Gera um número inteiro aleatório dentro de um intervalo específico (ex: 1 a 12)
            O limite superior é exclusivo, então 13 produz números até 12
            */

            int indexArr = random.Next(0, myNumbers.Length+15);  // '+15' para possa ocorrer o erro "Index was outside the bounds of the array"

            Console.WriteLine("myNumbers: { 1, 11, 54, 96, 7, 2, 20, 77, 1533, 33, 15, 3, 7, 9, 15, 87, 65, 10 };");
            Console.WriteLine($"TAMANHO ARRAY: {myNumbers.Length}  | INDEX ANGE [0, 1, 2, 3, . . ., {myNumbers.Length - 1}] | INDICE ESCOLHIDO --> {indexArr}");

            try
            {
                Console.WriteLine($"INDEX: {indexArr} | VALUE: {myNumbers[indexArr]}");
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

            int randAge = random.Next(1, 50);

            infos = $"RAND AGE IS: {randAge}";
            IJDEVLibs.ShowPrettyInfo(infos, lineShape, 60);

            try
            {
                IJDEVLibs.CheckAgeCustom(randAge);
            }
            catch (IJCustomExceptions ex)
            {
                //Console.WriteLine($"CHECK AGE ===>>>  {ex.Message}");
                Console.WriteLine($"{ex.ExCode} | {ex.Message}");
                Thread.Sleep(tempoSleepSegundos * 1000);
                return;
            }

            //ijlibs.CheckAge(17);     // will return error
            //ijlibs.CheckAge(22);     // success
            IJDEVLibs.CheckAge(18);       // success
            #endregion

            #region bloco ---------------- FIM DE APP --------------------
            Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair ...  ");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");
            #endregion

        }

    }
}