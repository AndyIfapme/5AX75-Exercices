namespace Theory_Heritage.Mocks;

public class FileMockService : IFileService
{
    public List<string> ReadFromFile(string path)
    {
        return new List<string>()
        {
            "Volvo",
            "Audi",
            "Ford",
            "Bmw",
            "Mini",
            "Jaguar"
        };
    }
}