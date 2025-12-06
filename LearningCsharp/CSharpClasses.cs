namespace LearningCsharp
{   
    public class CSharpClasses   
    {   
  
        public static void Main02(string[] args)
        {
            // ----------------------- INÍCIO DE APP ------------------------
            Console.Write("\n===================================================\n\n");
            Console.WriteLine($"ESTUDANDO CLASSES, OBJETOS E OOP EM C#!");
            Console.Write   ("\n===================================================\n\n");


            /*
            C# OOP
            -------------------------------
            C# - What is OOP?

            OOP stands for Object-Oriented Programming.

            Procedural programming is about writing procedures or methods that perform operations on the data, while object-oriented programming is about creating objects that contain both data and methods.

            Object-oriented programming has several advantages over procedural programming:

                1 - OOP is faster and easier to execute
                2 - OOP provides a clear structure for the programs
                3 - OOP helps to keep the C# code DRY "Don't Repeat Yourself", and makes the code easier to maintain, modify and debug
                4 - OOP makes it possible to create full reusable applications with less code and shorter development time

            Tip: The "Don't Repeat Yourself" (DRY) principle is about reducing the repetition of code. You should extract out the codes that are common for the application, and place them at a single place and reuse them instead of repeating it.
            */

            // Create an object of the MyClassOfCars class called audi
            MyClassOfCars audi = new MyClassOfCars(
                brand: "Audi", model: "Audi A6", year: 2022, color: "green", 
                maxSpeed:300, currentSpeed: 110, currentLocation: "Highway",
                ownerName: "Alice Smith",
                status: "Moving", destination: "City Center", licensePlateNumber: "AW7QY84"
            );
            audi.CarDetails();  // Call the CarDetails method of the audi object

            // Create an object of the MyClassOfCars class called tesla
            MyClassOfCars tesla = new MyClassOfCars(   
                brand: "Tesla", model: "Tesla Model S",
                color: "white", year: 2021, status: "Moving",
                maxSpeed: 280, currentSpeed: 90,
                currentLocation: "Downtown", ownerName: "Bob Johnson",
                destination: "Airport", licensePlateNumber: "CDR2Z03"
            );
            tesla.SpeedVerification();  

            // Create an object of the MyClassOfCars class called bmw
            MyClassOfCars bmw = new MyClassOfCars(    
                ownerName: "John Doe", color:"blue",
                brand:"BMW", model: "BMW X5",
                year: 2020, maxSpeed: 250, status: "Moving",
                currentSpeed:100, currentLocation: "Suburbs",
                destination: "Office", licensePlateNumber: "LRT3P57"
            );
            bmw.Accelerate(80);
            bmw.Accelerate(100);

            // Create an object of the MyClassOfCars class called ferrari
            MyClassOfCars ferrari = new MyClassOfCars(
                "red", "Ferrari", "Ferrari 488", 2023, 350, 0, 
                "Showroom", "Emma Brown", "stopped", "No where", "LQU7V61"
            );
            ferrari.StopCar();
            ferrari.StartCar("Mountain Cabin", 100);
            ferrari.Accelerate(200);
            ferrari.CarDetails();

            // Create an object of the MyClassOfCars class called lamborghini
            MyClassOfCars lamborghini = new MyClassOfCars(
                "yellow", "Lamborghini", "Lamborghini Aventador",
                2022, 340, 80, "Highway", "Liam Wilson", "Moving", 
                "Beach Resort", "WMS5F93"
            );
            lamborghini.StartCar("Mountain Cabin", 100);
            lamborghini.StopCar();
            lamborghini.Accelerate(50);
            lamborghini.CarDetails(); 

            // ----------------------- FIM DE APP ------------------------

            Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair...");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");

        }
    }
}

