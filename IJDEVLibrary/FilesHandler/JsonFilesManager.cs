using IJDEVLibrary.FilesHandler;
using System.Text.Json;

namespace IJDEVLibrary;


public class JsonFilesManager : FilesManagerBase
{

    public JsonFilesManager(string? fileName = null, string? content = null) : base("json", fileName) // Call the base class constructor (parameterless)
    {
    }

    // Save an object to a JSON file
    public void SaveToFile<T>(string filePath, T data)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string jsonString = JsonSerializer.Serialize(data, options);
        File.WriteAllText(filePath, jsonString);
    }

    // Load an object from a JSON file
    public T LoadFromFile<T>(string filePath)
    {
        if (!File.Exists(filePath))
            throw new FileNotFoundException("JSON file not found.", filePath);

        string jsonString = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<T>(jsonString);
    }

    // Update JSON file with new data (overwrite)
    public void UpdateFile<T>(string filePath, T newData)
    {
        SaveToFile(filePath, newData); 
    }

    // Delete JSON file
    public void DeleteFile(string filePath)
    {
        if (File.Exists(filePath))
            File.Delete(filePath);
    }
    
}