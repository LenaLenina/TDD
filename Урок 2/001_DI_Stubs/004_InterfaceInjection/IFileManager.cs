using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_InterfaceInjection
{
    public interface IFileManager
    {
        bool FindLogFile(string fileName, IDataAccessObject dataAccessObject);
    }
}
