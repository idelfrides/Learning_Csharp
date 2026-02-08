/*
---------------------
C# Files
---------------------

>>> Working With Files
The File class from the System.IO namespace, allows us to work with files:

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
-----

>>> Write To a File and Read It

*/


using IJDEVLibrary;
namespace LearningCsharp;

class ManageFiles
{
    class ManageFilesMainClass
    {

        public static async Task MainFiles(string[] args)
        {

            #region bloco introdução: ------------- INICIO APP ----------------
            var infos = "ESTUDANDO GERENCIAMENTO DE ARQUIVOS EM C#!\n\tMAIN CLASS:  ManageFilesMainClass\n\tAUXILIAR CLASS: ";

            AppInputOutputManager ijlibs = new AppInputOutputManager();

            char lineShape = '=';
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);
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

            var defaulUserName = "IDELFRIDES JORGE";
            var defaultFileName = "arquivo_teste_padrao";

            Console.Write("\n\n\t Digite seu NOME ::>>  ");
            var inputContent = Console.ReadLine();
            var userName = string.IsNullOrEmpty(inputContent) ? defaulUserName : inputContent;

            Console.WriteLine($"\n\n\t Olá, {userName}. Seja Bem-vindo(a) !\n\t Hoje vamos aplicar as operações de CRUD em cima de arquivos e você irá participar ativamente deste estudo");

            var crud_info = """            
                CRUD OVER A FILE. WHATS IS CRUD ?
                    C -> CREATE
                    R -> READ or RETRIEVE
                    U -> UPDATE
                    D -> DELETE            
            """;
            ijlibs.ShowPrettyInfo(crud_info, lineShape, 60);

            // CREATE: Create a file and write the content of writeTextx to it
            infos = $"CREATE: Creating a file and write the content into it";
            ijlibs.ShowPrettyInfo(infos, lineShape, 60, 5);

            Console.Write("\n\n\t Digite NOME do seu ARQUIVO (SEM extensão)::>>  ");
            inputContent = Console.ReadLine();
            var fileName = string.IsNullOrEmpty(inputContent) ? defaultFileName : inputContent;

            var fileFullPath = $"STAGE/{fileName}.txt";

            // Create a text string
            string lorenIpsumText = """What is Lorem Ipsum? Lorem Ipsum is simply dummy text of the printing and typesetting industry.Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.""";

            string whyDoWeUseIt = """Why do we use it? It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.The point of using Lorem Ipsum is that it has a more - or - less normal distribution of letters, as opposed to using 'Content here, content here', making it look like readable English. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.Various versions have evolved over the years, sometimes by accident, sometimes on purpose(injected humour and the like).""";

            Console.Write($"\n\n\t Digite o CONTEÚDO o arquivo <{fileFullPath}> ::>>  ");
            var fileContent = Console.ReadLine() is string s && s.Length > 0 ? s : lorenIpsumText;

            File.WriteAllText(fileFullPath, fileContent);

            // READ: Read the contents of the file
            infos = $"READ: Read the contents of the file <{fileName}>";
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);
            string readText = File.ReadAllText(fileFullPath);
            Console.WriteLine(readText);   // Output the content

            // UPDATE : Add a new content to end of the file
            infos = $"UPDATE : Add a new content to end of the file <{fileFullPath}>";
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);

            Console.Write($"\n\n\t Digite outro CONTEÚDO PARA arquivo <{fileFullPath}> ::>>  ");
            inputContent = Console.ReadLine();

            var fileContent2 = string.IsNullOrEmpty(inputContent) ? whyDoWeUseIt : inputContent;

            File.AppendAllText(fileFullPath, fileContent2);
            Console.Write($"\n\n\tCONTEÚDO do arquivo <{fileFullPath}> ATUALIZADO \n\n");
            readText = File.ReadAllText(fileFullPath);
            Console.WriteLine(readText);   // Output the content


            // DELETE : Delete the file with all it content
            infos = $"DELETE : Deleting the file with all it content <{fileName}>";
            ijlibs.ShowPrettyInfo(infos, lineShape, 60);

            ijlibs.BuildSpaces("vertical", 3);
            await ijlibs.EsperarAsync(tempoSegundos: 60);
            // File.Delete(fileFullPath);
            ijlibs.BuildSpaces("vertical", 3);

            #endregion

            #region bloco ---------------- FIM DE APP --------------------
            ijlibs.ShowAppEndInfo();
            #endregion

        }
    }
}