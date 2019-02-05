using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using NUnit.Framework;

namespace _006_Ninject
{
    [TestFixture]
    class FileManagerTest
    {
        [Test]
        public void FindLogFileTest6()
        {
            // Ninject Initialization
            IKernel ninjectKernel = new StandardKernel(new ConfigFileObjectData());

            FileManager manager = ninjectKernel.Get<FileManager>();

            Assert.IsTrue(manager.FindLogFile("file2.log"));
        }
    }
}
