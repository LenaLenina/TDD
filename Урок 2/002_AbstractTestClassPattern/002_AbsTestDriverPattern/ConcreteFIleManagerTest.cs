using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_AbsTestDriverPattern
{
    [TestFixture]
    class ConcreteFIleManagerTest : AbsBaseFileManagerTest<StubFileDataObject>
    {
    }
}
