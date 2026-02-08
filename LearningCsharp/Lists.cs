/* 
 LIST<T> METHODS ORGANIZED BY CRUD LOGIC:
 
 CREATE (Add/Insert elements):
    1.  Add -> Adds an object to the end of the List<T>.
    2.  AddRange -> Adds the elements of the specified collection to the end of the List<T>.
    3.  Insert -> Inserts an element into the List<T> at the specified index.
    4.  InsertRange -> Inserts the elements of a collection into the List<T> at the specified index.

 READ (Search/Retrieve elements):
    5.  Contains -> Determines whether the List<T> contains a specific value.
    6.  Exists -> Determines whether the List<T> contains elements that match the conditions defined by the specified predicate.
    7.  Find -> Searches for an element that matches the conditions defined by the specified predicate, and returns the first occurrence within the entire List<T>.
    8.  FindAll -> Retrieves all the elements that match the conditions defined by the specified predicate.
    9.  IndexOf -> Searches for the specified object and returns the zero-based index of the first occurrence within the entire List<T>.
    10. LastIndexOf -> Searches for the specified object and returns the zero-based index of the last occurrence within the entire List<T>.
    11. CopyTo -> Copies the entire List<T> to a compatible one-dimensional array, starting at the specified array index.
    12. ToArray -> Copies the elements of the List<T> to a new array.

 UPDATE (Modify structure/order):
    13. Reverse -> Reverses the order of the elements in the entire List<T>.
    14. Sort -> Sorts the elements in the entire List<T> using the default comparer.
    15. TrimExcess -> Sets the capacity to the actual number of elements in the List<T>, if that number is less than 90 percent of the current capacity.

 DELETE (Remove elements):
    16. Remove -> Removes the first occurrence of a specific object from the List<T>.
    17. RemoveAll -> Removes all the elements that match the conditions defined by the specified predicate.
    18. RemoveAt -> Removes the element at the specified index.
    19. RemoveRange -> Removes a range of elements from the List<T>.
    20. Clear -> Removes all elements from the List<T>.
*/


//------------------------------------------------------------------------------------



using IJDEVLibrary;
using System;
using System.Security.Cryptography;
namespace LearningCsharp;      //include the System.IO namespace


public class Lists 
{
	class ListProgram
	{
		public static void MainList(string[] args)
        {
            #region bloco ------------- introdução: INICIO APP ----------------
            var infos = "ESTUDANDO COLEÇÕES EM C#: LISTS \n\tMAIN CLASS:  ListProgram\n\tAUXILIAR CLASS: Lists";

            AppInputOutputManager ijlibs = new AppInputOutputManager();

            char lineShape = '=';
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);

            //ijlibs.CustomWait(tempoEmMinutos: 1);
            #endregion

            #region bloco ----------- APP propriamente dita --------------------
            string AllListMethods = """
                    * Add                
                    * AddRange
                    * Clear
                    * Contains
                    * CopyTo
                    * Exists
                    * Find
                    * FindAll
                    * IndexOf
                    * Insert
                    * InsertRange
                    * LastIndexOf
                    * Remove
                    * RemoveAll
                    * RemoveAt
                    * RemoveRange
                    * Reverse
                    * Sort
                    * ToArray
                    * TrimExcess
             """;

            var allMethodsInfo = $"C# METHODS OF List<T>: \n\n {AllListMethods}";
            ijlibs.ShowPrettyInfo(allMethodsInfo, lineShape, 60);

            List<string> brActors = new List<string>
            {
                "Fernanda Torres", "Deborah Bloch", "Lázaro Ramos",
                "Taís Araújo", "Cauã Reymond", "Juliana Paes", 
                "Bruno Gagliasso", "Giovanna Ewbank", "Rodrigo Santoro",
                "Marina Ruy Barbosa", "Selton Mello", "Paolla Oliveira", 
                "Mateus Solano", "Camila Pitanga", "Reynaldo Gianecchini"
            };

            var totalbrActors = brActors.Count;
            Console.WriteLine($"\nTotal brActors in the list: {totalbrActors}\n");
                     
            infos = "LISTING ALL MOST FAMOUS BRASILIAN ACTORS IN 2025 IN THE LIST CALLED brActors using my method 'ProcessListOfStrings'";
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);
            Console.WriteLine("\tIndex | Human ::>> LIST VALUE");
            ijlibs.ProcessListOfStrings(brActors);

            // Now, let's test all methods of List<T>

            #region bloco: ------------- TESTING CATEGORY: CREATE (Add/Insert elements):  ----------------
            infos = "TESTING CATEGORY: CREATE (Add/Insert elements):";
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);

            // Add -> Adds an object to the end of the List<T>.
            brActors.Add("Benvinda Papai");
            brActors.Add("Fernanda Montenegro");
            brActors.Add("IRINA Papai");
            Console.WriteLine($"\nTotal brActors in the list after Add() 3 elements: {brActors.Count}");

            // AddRange -> Adds the elements of the specified collection to the end of the List<T>.
            List<string> newActors = [
                "Bruna Marquezine", "Larissa Manoela", "Maisa Silva", "Maisa Silva"
            ];
            brActors.AddRange(new List<string> { "Sérgio Malandro", "Dina Menezes" });
            Console.WriteLine($"\nTotal brActors in the list after AddRange() 2 more: {brActors.Count}");
            brActors.AddRange(newActors);
            Console.WriteLine($"\nTotal brActors in the list after AddRange() 4 more: {brActors.Count}");
            brActors.AddRange("Dina Menezes 222");
            Console.WriteLine($"\nTotal brActors in the list after AddRange() 1 more single element is possible: {brActors.Count}");

            // Method Insert
            brActors.Insert(0, "Fernanda Montenegro");
            Console.WriteLine($"\nTotal brActors in the list after add Insert() index = 0 with 1 more: {brActors.Count}");

            // Method InsertRange
            brActors.InsertRange(1, new List<string> { "Mariana Rios", "Sandy Leah" });
            Console.WriteLine($"\nTotal brActors in the list after add InsertRange() index = 1 with 2 more: {brActors.Count}");

            Console.WriteLine("\n\nUPDATED LIST AFTER CREATE CATEGORY\n\n");            
            ijlibs.ProcessListOfStrings(brActors);

            #endregion

            #region bloco  ------------- TESTING CATEGORY: READ (Search/Retrieve elements):  ----------------
            infos = "TESTING CATEGORY: READ (Search/Retrieve elements):";
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);
            // Method Contains
            Console.WriteLine($"\nExists actor with 'Cauã Reymond' in the name?  {brActors.Contains("Cauã Reymond")}");
            bool exists = brActors.Exists(actor => actor.Contains("Marques"));
            Console.WriteLine($"\nExists actor with 'Marques' in the name?  {exists}");

            // Method Find
            string foundActor = brActors.Find(actor => actor.Contains("Pitanga"));
            Console.WriteLine($"\nFirst actor found with 'Pitanga' in the name:  {foundActor}");

            // Method FindAll
            List<string> foundActors = brActors.FindAll(actor => actor.Contains("Papai"));
            Console.WriteLine($"\nAll actors found with 'Papai' in the name:  {string.Join(", ", foundActors)}");

            // Method IndexOf
            int index = brActors.IndexOf("Fernanda Montenegro");
            Console.WriteLine($"\nIndex of 'Fernanda Montenegro': {index}");

            // Method LastIndexOf
            int lastIndex = brActors.LastIndexOf("Maisa Silva");
            Console.WriteLine($"\nLast Index of 'Maisa Silva': {lastIndex}");

            // Method CopyTo
            string[] actorArray = new string[brActors.Count];
            brActors.CopyTo(actorArray, 0);
            Console.WriteLine($"\nCopied brActors from index = 0 to actorArray. actorArray length: {actorArray.Length}");

            // Method ToArray
            string[] toArray = brActors.ToArray();
            Console.WriteLine($"\nConverted brActors to toArray. toArray length: {toArray.Length}");

            Console.WriteLine("\n\nUPDATED LIST AFTER READ CATEGORY\n\n");
            ijlibs.ProcessListOfStrings(brActors);

            #endregion

            #region bloco: ------------- TESTING CATEGORY: UPDATE (Modify structure/order):  ----------------
            infos = "TESTING CATEGORY: UPDATE (Modify structure/order):";
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);

            // Method Reverse
            brActors.Reverse();
            Console.WriteLine("\nList after Reverse():");
            ijlibs.ProcessListOfStrings(brActors);

            // Method Sort
            brActors.Sort();
            Console.WriteLine("\nList after Sort():\n");
            ijlibs.ProcessListOfStrings(brActors);

            // Method TrimExcess
            brActors.TrimExcess();
            Console.WriteLine($"\nCapacity of brActors after TrimExcess(): {brActors.Capacity}");
            #endregion
            
            #region bloco: ------------- TESTING CATEGORY: DELETE (Remove elements):  ----------------
            infos = "TESTING CATEGORY: DELETE (Remove elements):";
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);

            // Method Remove  
            brActors.Remove("Dina Menezes");
            Console.WriteLine($"\nTotal brActors in the list after Remove(): {brActors.Count}");

            // Method RemoveAll
            brActors.RemoveAll(actor => actor.Contains("Papai")); // Remove all actors with "Papai" in their name
            Console.WriteLine($"\nTotal brActors in the list after RemoveAll() with 'Papai': {brActors.Count}");

            // Method RemoveAt
            Random rand = new Random();
            int indexToRemove = rand.Next(0, brActors.Count);

            brActors.RemoveAt(indexToRemove); // Remove the item at index indexToRemove
            Console.WriteLine($"\nTotal brActors in the list after RemoveAt() index [{indexToRemove}]: {brActors.Count}");

            // Method RemoveRange
            brActors.RemoveRange(0, 2); // Remove first two items
            Console.WriteLine($"\nTotal brActors in the list after RemoveRange() [0,2]: {brActors.Count}");

            Console.WriteLine("\n\nUPDATED LIST AFTER DELETE CATEGORY:\n\n");
            ijlibs.ProcessListOfStrings(brActors);

            // Method Clear
            brActors.Clear();
            Console.WriteLine("\n LIST DETAILS AFTER Clear():\n\n");
            Console.WriteLine($"\nTotal brActors: {brActors.Count}");
            ijlibs.ProcessListOfStrings(brActors);

            #endregion

            #endregion  // Fim do bloco da app propriamente dita

            #region bloco ---------------- FIM DE APP --------------------
            /*
             Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair ...  ");

            Console.ReadKey(true);

            Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");
            */
            ijlibs.ShowAppEndInfo();
            #endregion

        }
    }
}
