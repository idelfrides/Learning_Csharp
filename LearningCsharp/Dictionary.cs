/*
 * 
DICTIONARY<TKey, TValue> METHODS ORGANIZED BY CRUD LOGIC:
     
CREATE (Add/Insert elements):
 1 - Add(TKey key, TValue value): Adds a key-value pair to the dictionary.
 2 - TryAdd(TKey key, TValue value): Tries to add a key-value pair to the dictionary and returns a boolean indicating success.
 3 - Indexer[TKey]: Gets or sets the value associated with the specified key.

READ (Retrieve elements):
 4 - TryGetValue(TKey key, out TValue value): Tries to get the value associated with the specified key.
 5 - ContainsKey(TKey key): Checks if the dictionary contains the specified key.
 6 - Count: Gets the number of key-value pairs in the dictionary.

UPDATE (Modify elements):
 7 - Indexer[TKey]: Gets or sets the value associated with the specified key.

DELETE (Remove elements):
 8 - Remove(TKey key): Removes the key-value pair with the specified key.
 9 - Clear(): Removes all key-value pairs from the dictionary.

*/


// ---------------------------------------------------------------------------------------------



using System;
using LearningCsharp;       // include the System.IO namespace


namespace LearningCsharp
{
    public class Dictionary
    {
        class DictionaryProgram
        {
            public static void Main(string[] args)
            {
                #region bloco --------------- Introdução: INICIO APP ----------------
                var infos = "ESTUDANDO COLEÇÕES EM C#: DICIONÁRIOS\n\tMAIN CLASS: DictionaryProgram\n\tAUXILIAR CLASS: Dictionary";

                IJDEVLibs ijlibs = new IJDEVLibs();

                char lineShape = '=';
                ijlibs.ShowPrettyInfo(infos, lineShape, 60);
                #endregion

                #region bloco -------------- App propriamente dita ------------------------

                // creating and initializing a dictionary
                var capitals = new Dictionary<string, string>()
                {
                    {"USA", "WRONG Washington, D.C."},
                    {"France", "WRONG CAPITAL"},
                    {"Japan", "FOR TEST"},
                    {"India", "New Delhi"},
                    {"Brazil", "Brasília"},
                    {"Canada", "Ottawa"},
                    {"Germany", "xxxxxxxxxxxx"},
                    {"Italy", "Rome"},
                    {"Australia", "Canberra"},
                    {"Russia", "Moscow"},
                    {"China", "Beijing"},
                    {"South Africa", "Pretoria"},
                    {"Mexico", "Mexico City"},
                    {"Spain", "Madrid"},
                    {"Argentina", "Buenos Aires"},
                    {"Egypt", "Cairo"},
                    {"Turkey", "Ankara"},
                    {"Sweden", "Stockholm"},
                    {"Norway", "Oslo"},
                    {"Netherlands", "Amsterdam"},
                    {"Switzerland", "Bern"},
                    {"UK", "London"},
                    {"South Korea", "Seoul"},
                    {"Indonesia", "Jakarta"},
                    {"Saudi Arabia", "Riyadh"},
                    {"Thailand", "Bangkok"},
                    {"Greece", "Athens"},
                    {"Portugal", "Lisbon"},
                    {"Poland", "Warsaw"},
                    {"Belgium", "Brussels"},
                    {"Austria", "Vienna"},
                    {"Czech Republic", "Prague"},
                    {"Hungary", "Budapest"},
                    {"Finland", "Helsinki"},
                    {"Denmark", "Copenhagen"},
                    {"Ireland", "Dublin"},
                    {"New Zealand", "Wellington"}

                };
                ijlibs.BuildSpaces("vertical", 2);
                ijlibs.ProcessDicionaryStr(capitals);
                Console.WriteLine($"\n\nTotal Countries in the dict: {capitals.Count}");

                string[] toRemove = {"France", "USA", "UK", "Portugal", "Spain", "Germany", "Italy", "Switzerland", "Netherlands",
                    "Indonesia", "South Korea", "Indonesia", "Saudi Arabia", "Thailand", "Greece", "Portugal", "Poland",
                    "Belgium", "Austria", "Czech Republic", "Hungary", "Argentina", "Mexico", "India", "Turkey"
                };
                

                // Demonstrating some"USA"); dictionary operations by each category: Create, Read, Update, Delete (CRUD)
                                     
                // CREATE (Add/Insert"Portugal"); elements):
                capitals.Add("Guiné-Bissau", "Bissau");
                capitals.Add("Mozambique", "Maputo");
                capitals.TryAdd("Angola", "Luanda");
                capitals.TryAdd("Cabo Verde", "Praia");
                capitals.TryAdd("São Tomé and Príncipe", "São Tomé");
                capitals["Timor-Leste"] = "Dili";
                capitals["Senegal"] = "Dakar";
                capitals["Jamaica"] = "WRONG CAPITAL";  // correct one : Kingston 

                Console.WriteLine($"\n\nTotal Countries in the dict after create category: {capitals.Count}");
                Console.WriteLine("\nUPDATED DICT AFTER CREATE CATEGORY\n\n");
                ijlibs.ProcessDicionaryStr(capitals);


                // READ (Retrieve elements):
                if (capitals.TryGetValue("Brazil", out string capital)) { Console.WriteLine($"The capital of Brazil is {capital}."); }
                if (capitals.TryGetValue("USA", out capital)) { Console.WriteLine($"The capital of USA is {capital}."); }

                if (capitals.ContainsKey("Japan")) { 
                    Console.WriteLine("Japan is in the dictionary ? YES"); 
                }else
                {
                    Console.WriteLine("Japan is in the dictionary ? NO");
                }
                           
                Console.WriteLine($"Senegal is in the dictionary ? {capitals.ContainsKey("Senegal")}");
                Console.WriteLine($"Colombia is in the dictionary ? {capitals.ContainsKey("Colombia")}");
             
                Console.WriteLine($"The capital of Senegal is {capitals["Senegal"]}.");

                Console.WriteLine($"\n\nTotal Countries in the dit after read category: {capitals.Count}");                
                Console.WriteLine("\nUPDATED DICT AFTER READ CATEGORY\n\n");
                ijlibs.ProcessDicionaryStr(capitals);


                // UPDATE (Modify elements):
                capitals["USA"] = "Washington, D.C.";
                capitals["Germany"] = "Berlin";
                capitals["Jamaica"] = "Kingston";
                capitals["France"] = "Paris";
                capitals["Japan"] = "Tokyo";

                Console.WriteLine($"\n\nTotal Countries in the dict after UPDATE category: {capitals.Count}");
                Console.WriteLine("\nUPDATED DICT AFTER UPDATE CATEGORY\n\n");
                ijlibs.ProcessDicionaryStr(capitals);

                // DELETE (Remove elements):
                foreach (var c in toRemove) {
                    capitals.Remove(c);
                }
                     
                Console.WriteLine($"\n\nTotal Countries in the dict after DELETE CATEGORY: {capitals.Count}");
                Console.WriteLine("\nUPDATED DICT AFTER DELETE CATEGORY\n\n");
                ijlibs.ProcessDicionaryStr(capitals);

                // CLEAR 
                capitals.Clear();

                Console.WriteLine($"\n\nTotal Countries in the dict after CLEAR operation: {capitals.Count}");
                Console.WriteLine("\nUPDATED DICT AFTER CLEAR ACTION\n\n");
                ijlibs.ProcessDicionaryStr(capitals);

                // ----------------------------------------------------------------------------------------
                // Another way to create a new dictionary, but not inicializing it
                // ----------------------------------------------------------------------------------------

                infos = "Another way to create a new dictionary, but not inicializing it. Let's learn how it works ...";
                ijlibs.ShowPrettyInfo(infos, lineShape, 80);
                
                //only create a new dictionary called actorsDict
                Dictionary<string, int> actorsDict = new();

                // Adding values to actorsDict
                actorsDict.TryAdd("Lázaro Ramos", 47);
                actorsDict.Add("Taís Araújo", 47);
                actorsDict.Add("USA", 249);
                actorsDict.TryAdd("Bruno Gagliasso", 43);             
                actorsDict.Add("Giovanna Ewbank", 39);             
                actorsDict.Add("Marina Ruy Barbosa", 30);                             
                actorsDict.Add("Paolla Oliveira", 43);                 
                actorsDict.TryAdd("Camila Pitanga", 48);

                Console.WriteLine($"USA exists in the dict <TryGetValue()> ? {actorsDict.TryGetValue("USA", out int actorAge)}");
                actorsDict.Remove("USA");
                Console.WriteLine($"USA exists in the dict <ContainsKey()> ? {actorsDict.ContainsKey("USA")}");

                Console.WriteLine($"\n\nTotal ELEMENTS in the dictionary (dict) after all operations made for test: {actorsDict.Count}");
                Console.WriteLine("\nIDADE DOS ATORES DA GLOBO EM 2025\n");
                ijlibs.ProcessDicionaryInt(actorsDict);


                #endregion

                #region bloco ---------------- FIM DE APP --------------------
                Console.Write($"{Environment.NewLine}\nPressione qualquer tecla para sair  . . . ");

                Console.ReadKey(true);

                Console.Write("\n\n\n==================== FIM DE APP ====================\n\n\n\n");
                #endregion
            }

        }
    }
}
