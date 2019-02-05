using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _002_ConstructorInjection
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest2()
        {
            FileManager mgr = new FileManager(new StubFileDataObject());
            Assert.IsTrue(mgr.FindLogFile("file2.log"));
        }
    }
}
