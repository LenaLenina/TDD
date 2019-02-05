using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _003_PropertyInjection
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest3()
        {
            FileManager mgr = new FileManager();
            mgr.DataAccessObject = new StubFileDataObject();
            Assert.IsTrue(mgr.FindLogFile("file2.log"));
        }
    }
}
