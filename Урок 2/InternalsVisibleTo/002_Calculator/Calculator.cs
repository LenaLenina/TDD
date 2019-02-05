using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;


// Задает видимость типов для заданной сборки.
[assembly: InternalsVisibleTo("001_TestOperations")]

namespace _002_Calculator
{
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
