using IJDEVLibrary;
using IJDEVLibrary.LogsHandler;
using IJDEVLibrary.SOLID_ILLustration;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text;

namespace LearningCsharp
{
    
    //Exemplo clássico(C# 13 e anteriores)
    public static class StringExtensions
    {

        // Método de extensão para verificar se uma string é nula ou vazia
        public static bool IsNullOrEmpty(this string valueT)
        {
            return string.IsNullOrEmpty(valueT);
        }

        public static string CapitalizeFirst(this string value02)
        {
            if (string.IsNullOrEmpty(value02)) return value02;

            return char.ToUpper(value02[0]) + value02.Substring(1);
        }
    }


    // Exemplo com Extension Members(C# 14) - ainda em preview, sujeito a mudanças
    // não irá compilar, apenas para fins de demonstração do conceito
    /*
    public static class ExtensionMembersCSharp14
    {
        extension string
        {
            public void IsPalindrome()
            {
                if (string.IsNullOrEmpty(this)) return false;
                var reversed = new string(this.Reverse().ToArray());
                return this.Equals(reversed, StringComparison.OrdinalIgnoreCase);
            }

            public int WordCount => this.Split(' ').Length;
        }
    }
    */
  

    public class ExtensionMethodsDemo
    {
        public static void Main(string[] args)
        {

            #region block code 1 --------- START OF APP ----------------------

            // Instance section
            // In this section, you can instantiate all the classes you will use in the application.
            JCustomLogger logger = new("ExtensionMethodsDemo");
            AppInputOutputManager iom = new();

            // Value definition for Constants and fields section
            var infos = "LEARNING AND PRACTICING SOLID ExtensionMethods IN C#";
            var summary = "This App attempts to show how to apply in code the concept of <Extension Methods>. \n I will show the correct approch of extensions methods";
            char lineShape = '*';
            int lineLen = 0;
            int vspace = 2;
            int hspace = 0;
            bool useTab = false;

            // Instance member call section
            iom.ShowAppInfo(title: infos, summary: summary);

            #endregion // --- starting app region ends here ---

            #region block code 2 --------- THE LOGIC OF APP GOES HERE --------

            logger.Info("region block code 2 --------- THE LOGIC OF APP GOES HERE --------\n\n");

            #region Chamando como se fosse método da instância
            string str1 = null;
            string str2 = "";
            string str3 = "hello world";

            Console.WriteLine($"Null test result:  {str1.IsNullOrEmpty()}"); // True
            Console.WriteLine($"Empty test result:  {str2.IsNullOrEmpty()}"); // True
            Console.WriteLine($"Hello world test result:  {str3.IsNullOrEmpty()}"); // False
            Console.WriteLine($"Capitalize first test result (hello world):  {str3.CapitalizeFirst()}"); // Hello world

            #endregion


            #region Testes com Extension Members (C# 14) - ainda em preview, sujeito a mudanças
            
            string texto = "radar";
            //Console.WriteLine(texto.IsPalindrome()); // True
            //Console.WriteLine("Olá mundo incrível".WordCount); // 3

            #endregion 

            #endregion // --- logic of app region ends here ---

            #region block code 3 --------- END OF APP ------------------------

            iom.ShowAppEndInfo();

            #endregion // --- closing region ends here ---
        }
    }
}