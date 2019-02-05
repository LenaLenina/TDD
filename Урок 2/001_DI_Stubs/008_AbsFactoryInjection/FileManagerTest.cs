using System;
using NUnit.Framework;
using _008_AbsFactoryInjection.AbstractFactory;

namespace _008_AbsFactoryInjection
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest8()
        {
            var client = new Client(new StubConcreteFactory());

            IFileManager mgr = client.Run();

            string fileName = "file1.txt";

            Assert.IsTrue(mgr.FindLogFile(fileName));
        }
    }
}
