using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _001_Mock
{
    [TestFixture]
    class LogAnalyzerTest
    {
        [Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            MockService mockService = new MockService();

            LogAnalyzer log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            Assert.AreEqual("Filename too short:abc.ext", mockService.LastError);
        }
    }
}
