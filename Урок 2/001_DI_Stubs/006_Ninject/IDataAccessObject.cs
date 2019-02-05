using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Ninject
{
    interface IDataAccessObject
    {
        List<string> GetFiles();
    }
}
