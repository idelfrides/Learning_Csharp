using System.Text.Json;
namespace IJDEVLibrary.FilesHandler;


public class TextFilesManager: FilesManagerBase
{

    public string defaultContent = "Default text file content to be used in a Console App: FilesManagerBase class.";

    public TextFilesManager(string? fileName = null, string? content = null):base("txt", fileName) // Call the base class constructor (parameterless)
    {
        //FilesManagerBase fmo = new(fileName, ".txt"); // Call the base class constructor with fileName and fileType parameters
        this.defaultContent = content ?? defaultContent;
    }

    public string GetFileContent()
    {
        string content = File.ReadAllText(this.FullFilePath);
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
        File.WriteAllText(this.FullFilePath, this.defaultContent);
        Console.WriteLine($"File created at: {this.FullFilePath}");
    }

    public void CreateFileWithContent(string content)
    {
        // Create a file and write a content to it now.
        // verify if content is null or empty
        if (string.IsNullOrEmpty(content))
        {
            throw new IJCustomExceptions(4, "Content is null or empty.");
        }

        File.WriteAllText(this.FullFilePath, content);
        Console.WriteLine($"File created with content successfuly at: {this.FullFilePath}");
    }
    
}