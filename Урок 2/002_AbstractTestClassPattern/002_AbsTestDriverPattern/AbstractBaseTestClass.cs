using NUnit.Framework;
using System;

namespace _002_AbsTestDriverPattern
{

    class AbsBaseFileManagerTest<T> where T : IDataAccessObject
    {
        protected  T LocalFactoryMethod()
        {
            return (T) Activator.CreateInstance(typeof(T));
        }

        [Test]
        public void FindLogFileTest9()
        {
            T dataAccessObj = LocalFactoryMethod();

            var mgr = new FileManager(dataAccessObj);

            var result = mgr.FindLogFile("file1.txt");

            Assert.IsTrue(result);
        }
    }
}
