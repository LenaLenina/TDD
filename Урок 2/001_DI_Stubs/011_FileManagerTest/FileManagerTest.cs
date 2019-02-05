using System;
using NUnit.Framework; 
using _011_Encapsulation;
using System.Runtime.CompilerServices;


namespace _011_Encapsulation
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
