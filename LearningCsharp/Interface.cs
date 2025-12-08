/*
------------------------------
C# Interface
------------------------------

Interfaces
Another way to achieve abstraction in C#, is with interfaces.

An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):
----------------

It is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself and others to remember that it is an interface and not a class.

By default, members of an interface are abstract and public.

Note: Interfaces can contain properties and methods, but not fields.

To access the interface methods, the interface must be "implemented" (kinda like inherited) by another class. To implement an interface, use the : symbol (just like with inheritance). The body of the interface method is provided by the "implement" class. Note that you do not have to use the override keyword when implementing an interface:

--------------------------

Notes on Interfaces:
    - Like abstract classes, interfaces cannot be used to create objects (in the example above, it is not possible to create an "IAnimal" object in the Program class)
    - Interface methods do not have a body - the body is provided by the "implement" class
    - On implementation of an interface, you must override all of its methods
    - Interfaces can contain properties and methods, but not fields/variables
    - Interface members are by default abstract and public
    - An interface cannot contain a constructor (as it cannot be used to create objects)

Why And When To Use Interfaces?
1) To achieve security - hide certain details and only show the important details of an object (interface).

2) C# does not support "multiple inheritance" (a class can only inherit from one base class). However, it can be achieved with interfaces, because the class can implement multiple interfaces. Note: To implement multiple interfaces, separate them with a comma (see example in the next chapter).

-----------------------------
C# Multiple Interfaces
-----------------------------
Multiple Interfaces
To implement multiple interfaces, separate them with a comma:

*/

class Interface
{
    interface IFirstInterface
    {
        void MyMethod();   // interface method
    }

    interface ISecondInterface
    {
        void MyOtherMethod();  // interface method
    }

    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void MyMethod()
        {
            Console.WriteLine("THIS IS THE INFO FOR 1º INTERFACE METHOD");
        }

        public void MyOtherMethod()
        {
            Console.WriteLine("THIS IS THE INFO FOR THE 2º INTERFACE METHOD");
        }
    }

    interface IAnimal   // Interface
    {
        void animalSound();  // interface method (does not have a body)
    }

    class Pig : IAnimal  // Pig "implements" the IAnimal interface
    {
        public void animalSound()
        {
            // The body of animalSound() is provided here
            Console.WriteLine("[animalSound] The pug says : wee wee wee");
        }
    }

    class Program
    {   
        public static void Main(string[] args)
        {
            #region bloco introdução: ------------- INICIO APP ----------------
            Console.Write
            ("\n===================================================\n\n");
            Console.WriteLine($"ESTUDANDO INTERFACE EM C#!\nMAIN CLASS:  Program\nAUXILIAR CLASS: IAnimal, Pig");
            Console.Write("\n===================================================\n\n");
            #endregion

            #region Normal interface behavior and examples
            Console.WriteLine(">>> Normal interface behavior and examples\n");
            Pig myPig = new Pig();
            myPig.animalSound();
            #endregion

            #region Multiple interface behavior and examples            
            Console.WriteLine("\n--------------------------------------\n");
            Console.WriteLine("\n>>> Multiinterface behavior and examples\n");
            DemoClass myObj = new DemoClass();
            myObj.MyMethod();
            myObj.MyOtherMethod();
            #endregion

            #region bloco ---------------- FIM DE APP --------------------

            Console.Write($"{Environment.NewLine}\n\nPressione qualquer tecla para sair...");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");
            #endregion

        }
    }
}