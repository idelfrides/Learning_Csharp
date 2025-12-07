/*
-------------------------
    C# Inheritance
-------------------------

Inheritance (Derived and Base Class)
In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

Derived Class (child) - the class that inherits from another class
    - Base Class (parent) - the class being inherited from
    - To inherit from a class, use the : symbol.

In the example below, the Car class (child) inherits the fields and methods from the Vehicle class (parent):
------------
Why And When To Use "Inheritance"?
- It is useful for code reusability: reuse fields and methods of an existing class when you create a new class.

Tip: Also take a look at the next chapter, 'Polymorphism', which uses inherited methods to perform different tasks.
------------
The sealed Keyword
If you don't want other classes to inherit from a class, use the sealed keyword:


*/

class Inheritance
{
    #region auxiliar classes
    class WMSuperVehicles  // base class (parent)
    {
        public string brand = "Lamborghini";
        public string moveStatus = "Stopped";

        // Automatic Properties (Short Hand) for private field 'year' 
        public int Year {get; set; }

        // property for private field 'color' 
        public string Color { get; set; }
        public void Honk()
        {
            Console.WriteLine("Poop, Pooop");
        }

        public void MovingStatus()
        {
            Console.WriteLine($"{this.moveStatus}");
        }
    }

    sealed class VehicleActions
    {
        public void Smoke()
        {
            Console.WriteLine("THE CAR IS SMOKING A LOT ...");
        }
    }

    /*'Inheritance.Car': cannot derive from sealed type 'Inheritance.VehicleActions'CS0509
      class Inheritance.VehicleActions
    */
    // class Car : VehicleActions  // derived class (child)

    class Car : WMSuperVehicles  // derived class (child)
    {
        public string modelName = "Aventador";  // Car field
    }
    #endregion


class InheritanceMainClass
{

    public static void Main06(string[] args)
    {

        #region bloco introdução: ------------- INICIO APP ----------------
        Console.Write("\n===================================================\n\n");
        Console.WriteLine($"ESTUDANDO HERANAÇA EM C#!\nMAIN CLASS:  InheritanceMainClass\nAUXILIAR CLASSES:  WMSuperVehicles, Car");
        Console.Write("\n===================================================\n\n");
        #endregion

        #region bloco de código da app propriamente dito

        // create a Car object to access methods and fields within it
        Car myCar = new Car();

        // Call the honk() method (From the Vehicle class) on the myCar object
        myCar.moveStatus = "Moving";
        // myCar.MovingStatus();
        myCar.Honk();

        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
        Console.WriteLine($"THE CAR {myCar.brand} {myCar.modelName} IS");
        myCar.MovingStatus();

        #endregion


        #region bloco ---------------- FIM DE APP --------------------

        Console.Write($"{Environment.NewLine}\n\nPressione qualquer tecla para sair...");

        Console.ReadKey(true);

        Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");
        #endregion

    }
}
}