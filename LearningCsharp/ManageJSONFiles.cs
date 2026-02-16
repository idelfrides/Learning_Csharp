/*
---------------------
C# JSON FILES 
---------------------

>>> Working With JSON Files
The File class from the System.IO namespace, allows us to work with files:
To manage .json files in C#, you typically use the System.Text.Json namespace (built into .NET Core and later). It provides fast, modern JSON serialization and deserialization. Let’s build a small utility class with methods to read, write, and update JSON files


The File class has many useful methods for creating and getting information about files. For example:

Method	Description
AppendText()	Appends text at the end of an existing file
Copy()	Copies a file
Create()	Creates or overwrites a file
Delete()	Deletes a file
Exists()	Tests whether the file exists
ReadAllText()	Reads the contents of a file
Replace()	Replaces the contents of a file with the contents of another file
WriteAllText()	Creates a new file and writes the contents to it. If the file already exists, it will be overwritten.

------
For a full list of File methods, go to Microsoft .Net File Class Reference.
------

>>> Write To a File and Read It

*/



using IJDEVLibrary;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text.Json;
using IJDEVLibrary.FilesHandler;
//using IJDEVLibrary;
namespace LearningCsharp;

class ManageJSONFiles : JsonFilesManager
{
   
    public static void MainJS(string[] args)
    {

        #region bloco introduction: ------------- INICIO APP ----------------
        var infos = "STUDYING HOW TO MANAGE JSON FILES IN .NET/C#!\n\tMAIN CLASS:  ManageFilesMainClass\n\tAUXILIAR CLASS: ";

        int fileUseApproch;

        //fileUseApproch = 1;  // 1 --> using a default file name for demonstration purposes,
        fileUseApproch = 2;    // 2 --> using the person's full name to create a unique file name for each person

        /*
            * --> AppInputOutputManager iomo = new AppInputOutputManager(); 
            * 
            *  This is the old way to instantiate a class, but with C# 10.0 and later, 
            *  we can use the new way to instantiate a class without the need to specify the class name again, 
            *  thanks to the new feature called "Target-typed new expressions", 
            *  which allows us to omit the type on the right-hand side of an object creation expression when the 
            *  type can be inferred from the context.
        */


        AppInputOutputManager iomo = new();
        JsonFilesManager jfmo = new();

        char lineShape = '=';
        iomo.ShowPrettyInfo(infos, lineShape, 60);
        #endregion

        #region bloco da app propriamente dita
        /*-------------------------------------------------
                CRUD OVER A FILE. WHATS IS CRUD ?
                    C -> CREATE
                    R -> READ
                    U -> UPDATE
                    D -> DELETE
        ---------------------------------------------------
        */


        // Save
        iomo.ShowPrettyInfo("Creating and saving a PersonDescription object to a JSON file...", lineShape, 50);
        PersonDescription person = new PersonDescription(fullName:"Barack Obama",
                                                         age:30,
                                                         address:"123 Main St",
                                                         gender:"Male",
                                                         phoneNumber:"123-456-7890",
                                                         nationality:"American",
                                                         countryOfResidence:"USA",
                                                         scholarship:"Degree",
                                                         occupation:"Professor",
                                                         maritalStatus:"Married",
                                                         email:"barackobama@gmail.com",
                                                         salary:100000.0m);


        // Example usage
        var manager = new JsonFilesManager();
        
        if (fileUseApproch == 1)  // using default file name for demonstration purposes
        {
            manager.SaveToFile(jfmo.FullFilePath, person);
        }
        else if (fileUseApproch == 2)
        {
            // Using full name to create a unique file name for each person,
            // replacing spaces with underscores and converting to lowercase
            var buildfileName = person.FullName.ToLower().Replace(" ", "_");
            jfmo.FullFilePath = $"STAGE/{buildfileName}.json";

            manager.SaveToFile(jfmo.FullFilePath, person);
        }

        // ckecking if the STAGE directory exists, if not, create it
        if (!Directory.Exists("STAGE"))
        {
            Directory.CreateDirectory("STAGE");
        }
        
        if (File.Exists(jfmo.FullFilePath))
        {
            iomo.ShowPrettyInfo($"The file {jfmo.FullFilePath} already exists. Do you want to overwrite it? (y/n)", lineShape, 50);
            string userInput = iomo.InputContentHandler("Enter your choice: ", "n");
            if (userInput.ToLower() != "y")
            {
                iomo.ShowPrettyInfo("Operation cancelled by the user.", lineShape, 50);
                return;
            }
        }     

        // Load
        iomo.ShowPrettyInfo("Loading the file we just created...", lineShape, 50);
        PersonDescription loadedPerson = manager.LoadFromFile<PersonDescription>(jfmo.FullFilePath);
        Console.WriteLine($"Loaded PersonDescription: {loadedPerson.FullName}, {loadedPerson.Age}, an {loadedPerson.Nationality} {loadedPerson.Occupation} with {loadedPerson.Scholarship} earns {loadedPerson.Salary}");

        // Update
        iomo.ShowPrettyInfo("Updating the loaded file...", lineShape, 50);
        loadedPerson.Age = 64;
        loadedPerson.Occupation = "Ex-President";
        loadedPerson.Scholarship = "PhD";
        manager.UpdateFile(jfmo.FullFilePath, loadedPerson);

        iomo.ShowPrettyInfo("Loading the updated file...", lineShape, 50);
        PersonDescription updatedPerson = manager.LoadFromFile<PersonDescription>(jfmo.FullFilePath);
        Console.WriteLine($"Loaded PersonDescription: {updatedPerson.FullName}, {updatedPerson.Age}, an {updatedPerson.Nationality} {updatedPerson.Occupation} with {updatedPerson.Scholarship} earns {updatedPerson.Salary}");


        // Delete
        iomo.ShowPrettyInfo("Deleting the file...", lineShape, 50);
        //manager.DeleteFile(jfmo.FullFilePath);


        /*
            * --------------------------------------------------------------
            * 
            📌 Key Points
            - JsonSerializer.Serialize → Converts objects to JSON string.
            - JsonSerializer.Deserialize < T > → Converts JSON back to objects.
            - WriteIndented = true → Makes JSON human - readable.
            - Works with any type(T) thanks to generics.
            - Supports complex types, including nested objects and collections.
            */

        #endregion

        #region bloco ---------------- FIM DE APP --------------------
        iomo.ShowAppEndInfo();
        #endregion

    }
    
}