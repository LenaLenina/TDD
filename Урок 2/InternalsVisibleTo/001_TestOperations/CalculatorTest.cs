using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using _002_Calculator;

namespace TestOperations
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void TestAdd()
        {
            // Класс Calculator доступен благодаря атрибуту InternalsVisbleTo
            Calculator calc = new Calculator();
            int result = calc.Add(10, 20);

           Assert.AreEqual(30, result);
        }
    }
}
