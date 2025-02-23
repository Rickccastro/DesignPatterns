using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchiveTypes.Strategy;
public interface ICompression
{
    public void CompressArchive(string fileName);
}
