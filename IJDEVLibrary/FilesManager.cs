namespace IJDEVLibrary;

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
