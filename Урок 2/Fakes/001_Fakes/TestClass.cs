using System;
using NUnit.Framework;
using _002_CodeUnderTest;
using Microsoft.QualityTools.Testing.Fakes;

namespace Fakes
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestCurrentYear()
        {
            int fixedYear = 2000;

            // Шимы могут быть использованы только в ShimContext:
            using (ShimsContext.Create())
            {
                // Шым DateTime.Now возвращает фиксированную дату:
                System.Fakes.ShimDateTime.NowGet = () => { return new DateTime(fixedYear, 1, 1); };

                // Создание тестируемого компонента:
                var componentUnderTest = new MyClass();

                int year = componentUnderTest.GetTheCurrentYear();

                // Эта проверка всегда будет верна, если компонент работает:
                Assert.AreEqual(fixedYear, year);
            }
        }
    }
}
