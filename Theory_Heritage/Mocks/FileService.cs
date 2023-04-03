namespace Theory_Heritage.Mocks;

public class FileService : IFileService
{
    public List<string> ReadFromFile(string path)
    {
        var lines = File.ReadAllLines(path);
        return lines.ToList();
    }
}