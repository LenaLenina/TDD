using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _001_AbstractTestClassPattern
{
    abstract class AbstractTestClass
    {
        [SetUp]
        public virtual void SetUp()
        {
            FactoryClass.SetDataAccessObject(new FileDataObject()); 
        }

        [Test]
        public void FindLogFileTest1()
        {
            FileManager mgr = new FileManager();

            Assert.IsTrue(mgr.FindLogFile("file1.txt"));
        }
    }
}
