/*

------------------------------
C# Abstraction
------------------------------

Abstract Classes and Methods
Data abstraction is the process of hiding certain details and showing only essential information to the user.
Abstraction can be achieved with either abstract classes or interfaces(which you will learn more about in the next chapter).

The abstract keyword is used for classes and methods:

Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

Abstract method: can only be used in an abstract class, and it does not have a body. The body is provided by the derived class (inherited from).
An abstract class can have both abstract and regular methods:
--------------

Why And When To Use Abstract Classes and Methods?
To achieve security - hide certain details and only show the important details of an object.

Note: Abstraction can also be achieved with Interfaces, which you will learn more about in the next chapter.

*/

class Abstraction
{
 
    abstract class Animal   // Abstract class
    {
        // animalSound -> Abstract method (does not have a body)
        public abstract void animalSound();

        public void sleep()   // Regular method
        {
            Console.WriteLine("Zzzzzzz");
        }
    }

    class Pig : Animal  // Derived class (inherit from Animal)
    {
        public override void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("The pig says: wee wee");
        }
    }
    
    public static void Main(string[] args)
    {
        #region bloco introdução: ------------- INICIO APP ----------------
        Console.Write
        ("\n===================================================\n\n");
        Console.WriteLine($"ESTUDANDO ABSTRAÇÃO EM C#!\nMAIN CLASS:  Abstraction\nAUXILIAR CLASS: Animal, Pig");
        Console.Write("\n===================================================\n\n");
        #endregion

        //  Will generate an error : Cannot create an instance of the abstract type or interface 'Abstraction.Animal' ( CS0144 )
        // Animal myObj = new Animal();

        Pig myPig = new Pig();  // Create a Pig object
        myPig.animalSound();    // Call the abstract method
        myPig.sleep();          // Call the regular method


        #region bloco ---------------- FIM DE APP --------------------
        Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair ...  ");

        Console.ReadKey(true);

        Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");
        #endregion
    }
}