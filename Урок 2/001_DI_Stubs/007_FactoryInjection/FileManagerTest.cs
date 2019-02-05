using System;
using NUnit.Framework;

namespace _007_FactoryInjection
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest7()
        {
            FactoryClass.SetDataAccessObject(new StubFileDataObject());

            FileManager mgr = new FileManager();

            Assert.IsTrue(mgr.FindLogFile("file1.txt"));
        }
    }
}
