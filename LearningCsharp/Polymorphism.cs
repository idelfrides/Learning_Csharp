
/*
---------------------------------
C# Polymorphism
---------------------------------

Polymorphism and Overriding Methods
Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.

Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class. Polymorphism uses those methods to perform different tasks. This allows us to perform a single action in different ways.
-------------------

Why And When To Use "Inheritance" and "Polymorphism"?
- It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.

*/


class Polymorphism
{

    class Animal  // Base class (parent) 
    {
        public virtual void animalVirtualSound()
        {
            Console.WriteLine("THE ANIMAL MAKES A SOUND!");
        }

        public void animalSoundTeste()
        {
            Console.WriteLine("THE ANIMAL MAKES A SOUND - TEST!");
        }
    }

    class Pig : Animal // Derived class (child)
    {
        
        public override void animalVirtualSound()
        {
            Console.WriteLine("The Pig says: wee wee");
        }

        public void animalSound2()
        {
            Console.WriteLine("The Pig 2 says: woob woob");
        }
    }

    class Dog : Animal //  Derived lass (child)
    {
        public override void animalVirtualSound()
        {
            Console.WriteLine("THE DOG SAYS: bow wow");
        }

        public void animalSound3()
        {
            Console.WriteLine("THE DOG 2 SAYS: weeow weeow");
        }
    }

    class Program
    {
        public static void MainPM(string[] args)
        {
            #region bloco introdução: ------------- INICIO APP ----------------
            Console.Write
            ("\n===================================================\n\n");
            Console.WriteLine($"ESTUDANDO POLIMORFISMO EM C#!\nMAIN CLASS:  Program\nAUXILIAR CLASS: Animal, Pig, Dog");
            Console.Write("\n===================================================\n\n");
            #endregion

            // Instancia objetos de classes, sendo todos eles do tipo Animal
            Animal myAnimal = new Animal();   // Create a Animal object
            Animal myPig = new Pig();         // Create a Pig object
            Animal myDog = new Dog();         // Create a Dog object

            // Com uso de palavra reservada de dotenet(.NET) - virtual'
            myAnimal.animalVirtualSound();
            myPig.animalVirtualSound();
            myDog.animalVirtualSound();
            myDog.animalSoundTeste();

            /*
             Instancia objetos de classes Pig e Dog, sendo cada 1 do seu respectivo tipo. Nestes casos, tanto os métodos vituais e não virtuais se tornam possíveis de acessar.
            */
            Console.WriteLine("---------------------------------");
            Pig myPig2 = new Pig();      // Create a Pig object as type Pig
            Dog myDog2 = new Dog();      // Create a Dog object as type Dog

            // Sem uso de palavra reservada de dotenet(.NET) - virtual'
            // myAnimal.animalSound();
            myPig2.animalVirtualSound(); // virtual method from class Animal
            myPig2.animalSound2();       // Not virtual method from class Pig
            myPig2.animalSoundTeste();   // Not virtual method from class Animal

            myDog2.animalVirtualSound();
            myDog2.animalSound3();


            #region bloco ------------------ FIM DE APP ----------------------

            Console.Write($"{Environment.NewLine}\n\nPressione qualquer tecla para sair...");

            Console.ReadKey(true);

            Console.Write("\n\n\n\n==================== FIM DE APP ===================\n\n\n\n");
            #endregion

        }
    }
}


