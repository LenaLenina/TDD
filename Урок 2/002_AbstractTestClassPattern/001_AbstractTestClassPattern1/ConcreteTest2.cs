using NUnit.Framework;
using System.Collections.Generic;

namespace _001_AbstractTestClassPattern
{

    [TestFixture]
    class FileManagerTest2 : AbstractTestClass
    {
        public override void SetUp()
        {
            FactoryClass.SetDataAccessObject(new StubFileDataObject());
        }

        //We can add more test methods here
        //. . .

        // Inherited member:

        //[Test]
        //public void FindLogFileTest1()
        //{
        //    FileManager mgr = new FileManager();

        //    Assert.IsTrue(mgr.FindLogFile("file1.txt"));
        //}
    }


    class StubFileDataObject : IDataAccessObject
    {
        public List<string> GetFiles()
        {
            List<string> list = new List<string>();
            list.Add("file1.txt");
            list.Add("file2.log");
            list.Add("file3.exe");

            return list;
        }
    }
}
