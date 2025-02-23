using ArchiveTypes.Strategy;

namespace ArchiveTypes.ConcreteStrategy;

public class Zip : ICompression
{
    public void CompressArchive(string fileName)
    {
        Console.WriteLine($"The archive {fileName} was compressed using the Zip format.");
    }
}
