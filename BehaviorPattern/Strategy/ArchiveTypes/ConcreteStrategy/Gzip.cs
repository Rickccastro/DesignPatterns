using ArchiveTypes.Strategy;

namespace ArchiveTypes.ConcreteStrategy;

public class Gzip : ICompression
{
    public void CompressArchive(string fileName)
    {
        Console.WriteLine($"The archive {fileName} was compressed using the Gzip format.");
    }
}
