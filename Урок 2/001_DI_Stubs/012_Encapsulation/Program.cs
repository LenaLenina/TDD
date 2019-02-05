using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_EncapsulationProblem
{
    class Program
    {
        static void Main()
        {
#if RELEASE
            string fileName = "file2.log";

            FileManager mgr = new FileManager();

            if (mgr.FindLogFile(fileName))
            {
                Console.WriteLine("File {0} is found!", fileName);
            }
            else
            {
                Console.WriteLine("File {0} is not found!", fileName);
            }

            Console.ReadKey();
#endif
        }
    }
}
