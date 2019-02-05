using System;
using NUnit.Framework;

namespace _009_LocalAbstractMethod
{
    class FileManagerUnderTest : FileManager
    {
        protected override IDataAccessObject LocalFactoryMethod()
        {
            return new StubFileDataObject();
        } 
    }


    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest9()
        {
            var mgr = new FileManagerUnderTest();

            var result = mgr.FindLogFile("file1.txt");

            Assert.IsTrue(result);
        }
    }
}
