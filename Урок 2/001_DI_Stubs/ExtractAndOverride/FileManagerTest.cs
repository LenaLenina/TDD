using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace _010_ExtractAndOverride
{
    class FileManagerUnderTest : FileManager
    {
        protected override List<string> FindLogFileExtension()
        {
            return new List<string> { "file1.txt", "file2.log", "file3.exe" };
        }
    }

    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest10()
        {
            var mgr = new FileManagerUnderTest();

            var result = mgr.FindLogFile("file1.txt");

            Assert.IsTrue(result);
        }
    }
}
