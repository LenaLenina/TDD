using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_ConstructorInjection
{
    interface IDataAccessObject
    {
        List<string> GetFiles();
    }
}
