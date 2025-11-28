using PasswordGenerator;

namespace LearningCsharp
{   
    public class PasswordGenerator
    {   
                
        public static void MainPG(string[] args)
        {
            Console.WriteLine($"\n\n\tHello!{Environment.NewLine}\tMy name is IJDEV PRO.\n\tYou are welcome to this app. Today we are going to experiment the usage of a nuget package - PasswordGenerator - in C-Sharp programming language.");

            // Basic usage

            // By default, all characters available for use and a length of 16
            // Will return a random password with the default settings 
            var pwd = new Password();
            var password = pwd.Next();

            Console.WriteLine($"\n\n\t A senha padrao gerada é ::>>  {password} ");
            Console.WriteLine($"\n\n\t A senha padrao gerada com uso de ToString() é ::>>  {password.ToString()} ");

            // Same as above but you can set the length. Must be between 8 and 128
            // Will return a password which is 32 characters long
            var pwd2 = new Password(passwordLength:32);
            var password2 = pwd2.Next();        

            Console.WriteLine($"\n\n\t A senha 2 gerada é ::>>  {password2} ");


            // Same as above but you can set the length. Must be between 8 and 128
            // Will return a password which only contains lowercase and uppercase characters and is 21 characters long.
            var pwd3 = new Password(
                includeLowercase: true, 
                includeUppercase: true, 
                includeNumeric: true, 
                includeSpecial: false,
                passwordLength: 10
            );
            var password3 = pwd3.Next();

            Console.WriteLine($"\n\n\t A senha 3 gerada é ::>>  {password3} ");

            // Fluent usage 

            /*
            You can build up your reqirements by adding things to the end, like .IncludeNumeric()
            This will return a password which is just numbers and has a default length of 16
            var pwd = new Password().IncludeNumeric();
            var password = pwd.Next();
            -------
            As above, here is how to get lower, upper and special characters using this approach
            var pwd = new Password().IncludeLowercase().IncludeUppercase().IncludeSpecial();
            var password = pwd.Next();
            --------
            This is the same as the above, but with a length of 128
            var pwd = new Password(128).IncludeLowercase().IncludeUppercase().IncludeSpecial();
            var password = pwd.Next();
            --------
            This is the same as the above, but with passes the length in using the method LengthRequired()
            var pwd = new Password().IncludeLowercase().IncludeUppercase().IncludeSpecial().LengthRequired(128);
            var password = pwd.Next();
            --------
            One Time Passwords
            If you want to return a 4 digit number you can use this:
            var pwd = new Password(4).IncludeNumeric();
            var password = pwd.Next();
            */

            Console.WriteLine($"\n\n\t Agora, vamos gerar uma senha usando o modo Fluente de uso do pacote PasswordGenerator...");

            // Specify your own special characters
            // You can now specify your own special characters
            var pwd4 = new Password(20).IncludeLowercase().IncludeUppercase().IncludeNumeric().IncludeSpecial("[]{}^_=");
            var password4 = pwd4.Next();

            Console.WriteLine($"\n\n\t A senha 4 gerada é ::>>  {password4} ");


            // ------------------------ FIM DE APP ---------------------------

            Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair...");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");

        }
    }
}

