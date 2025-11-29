using System.Runtime.InteropServices.Marshalling;

namespace LearningCsharp
{   
    public class MyClassOfCars    
    {   
        public string color;
        public string brand;
        public string model;
        public int year;
        public int maxSpeed;
        public int currentSpeed;
        public string currentLocation;
        public string ownerName;
        public string status; // Possible values: "Stopped", "Moving"
        public string destination = "No where";

        // Default constructor        
        public MyClassOfCars(string color, string brand, string model, int year, int maxSpeed, int currentSpeed, string currentLocation, string ownerName, string status,  string destination)
        {
            this.color = color;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.maxSpeed = maxSpeed;
            this.currentSpeed = currentSpeed;
            this.currentLocation = currentLocation;
            this.ownerName = ownerName;
            this.status = status;
            this.destination = destination;
        }

        // Method to display the car status and details
        public void CarStatus()
        {
            Console.WriteLine("\n\n\t ******* CAR STATUS AND DETAILS *******\n");

            MyClassOfCars obj = this;

            Console.WriteLine($"\n\t Car owner: {obj.ownerName}");
            Console.WriteLine($"\n\t Car brand: {obj.brand}");
            Console.WriteLine($"\n\t Car model: {obj.model}");
            Console.WriteLine($"\n\t Car color: {obj.color}");
            Console.WriteLine($"\n\t Car year: {obj.year}");
            Console.WriteLine($"\n\t Car max speed: {obj.maxSpeed} km/h");
            Console.WriteLine($"\n\t Current location: {obj.currentLocation}");
            Console.WriteLine($"\n\t Current status: {obj.status}");
            Console.WriteLine($"\n\t The car is moving to: {obj.destination}");
            Console.WriteLine($"\n\t Current speed: {obj.currentSpeed} km/h");

        }
                
    }
}

