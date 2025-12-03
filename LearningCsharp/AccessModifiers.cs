/*
Access Modifiers
By now, you are quite familiar with the public keyword that appears in many of our examples:
The public keyword is an access modifier, which is used to set the access level/visibility for classes, fields, methods and properties.

C# has the following access modifiers:
--------------------------------------------------------------------------------
 Modifier	 | Description
1- public	 | The code is accessible for all classes
2- private	 | The code is only accessible within the same class
3- protected | The code is accessible within the same class, or in a class     that is inherited from that class. You will learn more about inheritance in a later chapter
4- internal	 | The code is only accessible within its own assembly, but not from another assembly. You will learn more about this in a later chapter
--------------------------------------------------------------------------------

There's also two combinations: protected internal and private protected.

For now, lets focus on public and private modifiers.

----
Private Modifier
If you declare a field with a private access modifier, it can only be accessed within the same class:
----
Public Modifier
If you declare a field with a public access modifier, it is accessible for all classes:

----------------------------------------------
Why Access Modifiers?
To control the visibility of class members (the security level of each individual class and class member).

To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users. This is done by declaring fields as private. You will learn more about this in the next chapter.
---------------------------------------------

NOTE: 
By default, all members of a class are private if you don't specify an access modifier:

Example

class Car
{
  string model;  // private
  string year;   // private
}
*/


namespace LearningCsharp
{

    class USACars
    {
        // public fields
        public string brand = "BUGATTI";
        public int year;
        public string color = "CYAN";
        public int maxSpeed = 300;

        // explicit private fields
        private string model;
        private string destination = "No where";

        // implicit private fields by default
        int currentSpeed;

        string licensePlateNumber; 

    }


    public class AccessModifiers
    { 
        public static void Main04(string[] args)
        {
            // ----------------------- INÍCIO DE APP ------------------------
            Console.Write("\n===================================================\n\n");
            Console.WriteLine($"ESTUDANDO MODIFICADORES DE ACESSO EM C#!\nMAIN CLASSE:  AccessModifiers\nEXTENAL CLASS:  USACars");
            Console.Write("\n===================================================\n\n");

            USACars myObj = new USACars();

            /*
                'AccessModifiers.USACars.model' is inaccessible due to its protection level (CS0122) 
                
                -----------------
                   MY NOTE:
                -----------------
                PT-BR
                MENSAGEM AO EXECUTAR: error CS0122: "AccessModifiers.USACars.model" é inacessível devido ao seu nível de proteção que é 'private' 
                Isso significa que um campo ou classe ou método com modificar 'private' dentro de uma classe não pode ser acessado fora dessa classe. Neste caso concreto, a instrução `Console.WriteLine(myObj.model);` tenta acessar o campo 'model' que faz parte (pertence) à clasee USACars dentro do método Main(...) que não pertence à classe USACars. O método Main pertence à class 'AccessModifiers' .
            */

            // myObj.brand = "BUGATTI";
            myObj.year = 2025;
            myObj.color = "LIGHT Green";
            myObj.maxSpeed = 300;

            Console.WriteLine($"BRAND IS : {myObj.brand}");
            Console.WriteLine($"YAER IS : {myObj.year}");
            Console.WriteLine($"COLOR IS : {myObj.color}");
            Console.WriteLine($"MAX SPEED IS : {myObj.maxSpeed}");

            // Calling private fields of class 'USACars'
            /*
            myObj.model = "Chiron";
            myObj.destination = "CHICAGO";
            myObj.currentSpeed = 150;
            myObj.licensePlateNumber = "GATTI07";

            Console.WriteLine($"MODEL IS : {myObj.model}");
            Console.WriteLine($"DESTINTION TO : {myObj.destination}");
            Console.WriteLine($"CURRENT SPEED IS : {myObj.currentSpeed}");
            Console.WriteLine($"MAX SPEE IS : {myObj.licensePlateNumber}");
            */

            // ------------------------ FIM DE APP -----------------------------

            Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair ...  ");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");
        }
    }

}