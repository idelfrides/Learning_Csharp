/*
------------------------------
C# Interface
------------------------------

Interfaces
Another way to achieve abstraction in C#, is with interfaces.

An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies):


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