using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Encapsulation
{
    class StubFileDataObject : IDataAccessObject
    {
        public List<string> GetFiles()
        {
            List<string> list = new List<string>();
            list.Add("file1.txt");
            list.Add("file2.log");
            list.Add("file3.exe");

            return list;
        }
    }
}
