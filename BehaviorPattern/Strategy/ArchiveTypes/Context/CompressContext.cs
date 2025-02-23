using ArchiveTypes.ConcreteStrategy;
using ArchiveTypes.Strategy;

namespace ArchiveTypes.Context;

public class CompressContext
{
    private ICompression _icompression = new Zip();

    public void DefineStrategy( ICompression icompression)
    {
        _icompression = icompression;
    }

    public void CreateCompressedFile(string fileName)
    {
        _icompression.CompressArchive(fileName);    
    }
}
