using ArchiveTypes.ConcreteStrategy;
using ArchiveTypes.Context;

namespace ArchiveTypes;

internal class Program
{
    static void Main(string[] args)
    {
        var compressContext = new CompressContext();

        compressContext.DefineStrategy(new Rar());

        compressContext.CreateCompressedFile("Rar");


        var compressContextGzip = new CompressContext();

        compressContextGzip.DefineStrategy(new Gzip());

        compressContextGzip.CreateCompressedFile("Gzip");


        /* You don't need to specify the Zip type, by default, the compression archive type is Zip. */
        var compressContextZip = new CompressContext();

        compressContextZip.CreateCompressedFile("Zip");

    }
}
