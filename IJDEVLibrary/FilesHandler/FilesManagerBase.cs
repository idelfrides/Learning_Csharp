using System.Text.Json;

namespace IJDEVLibrary.FilesHandler;

public class FilesManagerBase
{

    public virtual string FullFilePath { get; set; }

    public FilesManagerBase(string fileType, string? fileName = null)
    {
        string defaultFileName = fileName ?? "defaultFileForExperiments";

        this.FullFilePath = $"STAGE/{defaultFileName}.{fileType}";
    }
     
}