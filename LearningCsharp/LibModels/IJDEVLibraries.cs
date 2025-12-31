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
        public string licensePlateNumber;
        public string destination = "No where";

        // Default constructor        
        public MyClassOfCars(string color, string brand, string model, int year, int maxSpeed, int currentSpeed, string currentLocation, string ownerName, string status, string destination, string licensePlateNumber)
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
            this.licensePlateNumber = licensePlateNumber;
        }

        // Method to display the car status and details
        public void CarDetails()
        {
            Console.WriteLine("\n\n\t******* CAR STATUS AND DETAILS *******\n");

            MyClassOfCars obj = this;

            Console.WriteLine($"\n\t Car Owner: {obj.ownerName}");
            Console.WriteLine($"\n\t Car Brand: {obj.brand}");
            Console.WriteLine($"\n\t Car Model: {obj.model}");
            Console.WriteLine($"\n\t Car License Plate Number: {obj.licensePlateNumber}");
            Console.WriteLine($"\n\t Car Color: {obj.color}");
            Console.WriteLine($"\n\t Car Year: {obj.year}");
            Console.WriteLine($"\n\t Car Max Speed: {obj.maxSpeed} km/h");
            Console.WriteLine($"\n\t Current Location: {obj.currentLocation}");
            Console.WriteLine($"\n\t Current Status: {obj.status}");
            Console.WriteLine($"\n\t Car is moving to: {obj.destination}");
            Console.WriteLine($"\n\t Current Speed: {obj.currentSpeed} km/h");
        }

        public void StopCar()
        {
            if (this.currentSpeed > 0)  // Car is moving, so it can be stopped
            {
                Console.Write($"\n\tGoint to STOP the car {this.brand} - {this.licensePlateNumber} ...\n\n");
                this.status = "Stopped";
                this.currentSpeed = 0;
                this.destination = "No where";
                Console.WriteLine($"\n\t The car {this.brand}: {this.licensePlateNumber} has stopped.");
            } else
            {
                Console.Write($"\n\t[NOTICE]: The car {this.brand} - {this.licensePlateNumber} is already STOPPED at {this.currentLocation}\n");
            }
        }

        public void StartCar(string newDestination, int speed)
        {
            if (this.status.Trim().ToUpperInvariant() == "STOPPED")
            {
                Console.Write($"\n\tGoint to START the car {this.brand} - {this.licensePlateNumber} ...\n\n");

                this.status = "Moving";
                this.currentSpeed = speed;
                this.destination = newDestination;
                Console.WriteLine($"\n\t The car {this.brand}: {this.licensePlateNumber} is now moving to {this.destination} at {this.currentSpeed} km/h.");
            }
            else
            {
                Console.Write($"\n\t[NOTICE]: The car {this.brand} - {this.licensePlateNumber} is already moving to {this.destination}\n");
            }
        }

        public void Accelerate(int increaseSpeed)
        {
            if (this.currentSpeed > 0)  // Car is moving, so the speed can be increased
            {
                Console.Write($"\n\tGoing to ACELERATE the car {this.brand} - {this.licensePlateNumber} ...\n\n");

                this.currentSpeed += increaseSpeed;
                Console.WriteLine($"\n\t The car {this.brand}- {this.licensePlateNumber} has accelerated to {this.currentSpeed} km/h.");
                this.SpeedVerification();
            } else
            {
                Console.WriteLine($"\n\t [NOTICE]: The car {this.brand}-{this.licensePlateNumber} is already STOPPED at {this.currentLocation} with speed {this.currentSpeed}");
            }
        }

        public void SpeedVerification()
        {
            Console.Write($"\n\tSpeedVerification for {this.brand} - {this.licensePlateNumber} ...\n\n");

            if (this.currentSpeed == 0)
            {
                Console.WriteLine($"\n\t The car {this.brand}-{this.licensePlateNumber} is already STOPPED at {this.currentLocation} with speed {this.currentSpeed}");
            }
            else if (this.currentSpeed > this.maxSpeed)
            {
                Console.WriteLine($"\n\t WARNING: The car {this.brand} - {this.licensePlateNumber} is exceeding the maximum speed of {this.maxSpeed} km/h!");
            }
            else if (this.currentSpeed > 0 || this.currentSpeed <= this.maxSpeed)
            {
                Console.WriteLine($"\n\t The car {this.brand}-{this.licensePlateNumber} is within the speed limit.");
            }
        }
    }

    public class FilesManager
    {
    
        public string filePath;
        //public string filetype = ".txt";
        public string defaultContent = "Default file content from IJDEVLibs.cs: FilesManager class.";

        public FilesManager(string fileName, string? content)
        {
            this.filePath = $"STAGE/{fileName}.txt";
            //this.defaultContent = content;

        }

        public string GetFileContent()
        {
            string content = File.ReadAllText(this.filePath);
            return content;
        }

        public void ShowFileInfo()
        {
            string content = this.GetFileContent();
            Console.WriteLine($"File Content: {content}");
        }

        public void CreateFile()
        {
            // Create a file to write to.
            //this.filetype
            File.WriteAllText(this.filePath, this.defaultContent);
            Console.WriteLine($"File created at: {this.filePath}");
        }

        public void CreateFileWithContent(string content)
        {
            // Create a file and write a content to it now.
            // verify if content is null or empty
            if (string.IsNullOrEmpty(content))
            {
                throw new IJCustomExceptions(4, "Content is null or empty.");
            }

            File.WriteAllText(this.filePath, content);
            Console.WriteLine($"File created with content successfuly at: {this.filePath}");
        }

    }

    public class IJDEVLibs
    {

        // IJDEVLibraries
        public IJDEVLibs()
        {
            Console.WriteLine("CONSTRUTOR <IJDEVLibs>");
        }
        public void ShowPrettyInfo(string info, char lineShape, int lineLen, int vspace = 3, int hspace = 0)
        {
            this.BuildLines(lineShape, lineLen, vspace, hspace);
            Console.WriteLine($"\t{info}");
            this.BuildLines(lineShape, lineLen, 0, hspace);
        }


        public int[] GenerateIntValuesArray(int qtd, int maxValue, int minValue = 0)
        {
            Random rand = new Random();

            int[] valuesArr = new int[qtd];
            for (int i = 0; i < qtd ; i++)
            {
                valuesArr[i] = rand.Next(minValue, maxValue + 1); // Scores between 0 and maxScore
            }
            return valuesArr;
        }

        public List<int> GenerateStudentAgesList(int numberOfStudents, int minAge, int maxAge)
        {
            Random rand = new Random();
            List<int> StudentAges = new List<int>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                StudentAges.Add(rand.Next(minAge, maxAge + 1)); // Ages between minAge and maxAge
            }
            return StudentAges;
        }

        public void ProcessList(List<string> myList, bool showIndex=true)
        {

            switch (showIndex)
            {
                case true:
                    for (int i = 0; i < myList.Count; i++) { Console.WriteLine($"\t{i} | {i + 1} ::>> {myList[i]}"); }
                    break;
                case false:
                    foreach (string item in myList) { Console.WriteLine($"\t{item}"); }
                    break;
                default:
                    Console.WriteLine("DEFAULT OPTION");
                    break;
            }
        }

        public void ProcessArrays(string[] myArray, bool showIndex=true)
        {
            switch (showIndex)
            {
                case true:
                    for (int i = 0; i < myArray.Length; i++) { Console.WriteLine($"\t{i} | {i + 1} ::> {myArray[i]}"); }
                    break;
                case false:
                    foreach (var item in myArray) { Console.WriteLine($"\t{item}\n"); }
                    break;
                default:
                    Console.WriteLine("DEFAULT OPTION");
                    break;
            }
        }

        public void ProcessDicionaryInt(Dictionary<string, int> myDict, bool showKeys=true)
        {

            switch (showKeys)
            {
                case true:
                    // foreach (var par in myDict) {Console.WriteLine($"\tChave: {par.Key}, Valor: {par.Value}");}
                    foreach (var par in myDict) {Console.WriteLine($"\t{par.Key} => {par.Value}"); }
                    break;
                case false:
                    foreach (var par in myDict) { Console.WriteLine($"\tValor: {par.Value}"); }
                    break;
                default:
                    throw new IJCustomExceptions(3, "GIVEN OPTION NOT FOUND -> Status 404");

            }
        }

        public void ProcessDicionaryStr(Dictionary<string, string> myDict, bool showKeys = true)
        {
            switch (showKeys)
            {
                case true:
                    // foreach (var par in myDict) { Console.WriteLine($"\tChave: {par.Key}, Valor: {par.Value}"); }
                    foreach (var par in myDict) { Console.WriteLine($"\t{par.Key} ::> {par.Value}"); }
                    break;
                case false:
                    foreach (var par in myDict) { Console.WriteLine($"\tValor: {par.Value}"); }
                    break;
                default:
                    throw new IJCustomExceptions(3, "GIVEN OPTION NOT FOUND -> Status 404");
            }
        }

        public void BuildLines(char lineShape, int lineLength, int vspace = 3, int hspace = 0)
        {
            if (vspace > 0)
            {
                this.BuildSpaces("vertical", vspace);
            }
            else if (hspace > 0)
            {
                this.BuildSpaces("horizontal", hspace);
            }
            string lineFormatted = new string(lineShape, lineLength);

            Console.WriteLine($"\t{lineFormatted}");
        }

        public void BuildSpaces(string spOrientation, int spLen)
        {
            switch (spOrientation)
            {
                case "vertical":
                    string vspace = new string('\n', spLen);
                    Console.Write(vspace);
                    break;
                case "horizontal":
                    string hspace = new string('\t', spLen);
                    Console.WriteLine(hspace);
                    break;
                default:
                    Console.WriteLine("DEFAULT");
                    break;
            }
        }

        public async Task EsperarAsync(int tempoSegundos)
        {
            Console.WriteLine($"Aguardando {tempoSegundos}s assincronamente para executar ação solicitada . . .");

            // O valor é em milissegundos
            await Task.Delay(TimeSpan.FromSeconds(tempoSegundos));

            Console.WriteLine("Pausa assíncrona terminada.");
        }

        public async void CustomWait(int tempoEmMinutos)
        {

            int tempoConvertidoSegundos;
            tempoConvertidoSegundos = tempoEmMinutos * 60;   // converte minutos para segundos
            Console.WriteLine($"Pausar {tempoEmMinutos} min assincronamente antes de executar ação solicitada . . .");

            // O valor é em milissegundos
            Thread.Sleep(tempoConvertidoSegundos * 1000);

            Console.WriteLine("Pausa assíncrona Finalizada.");
        }

        public void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            } else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        public void CheckAgeCustom(int age)
        {
            if (age < 18)
            {
                throw new IJCustomExceptions(1, $"Access denied - You must be at least 18 years old. AGE: {age} < 18");
            }
            else if (18 <= age & age < 25)
            {
                 throw new IJCustomExceptions(2, $"IDADE PERMITIDA COM RESTRIÇÕES: IDADE '18 <= {age} < 25' ");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

    }
    
    public class IJCustomExceptions : Exception
    {

        public IJCustomExceptions(int code, string message) : base(message)
        {
            ExCode = code;
        }

        public int ExCode { get; }
    }
    
}

