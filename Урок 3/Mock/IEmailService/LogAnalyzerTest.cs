using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _002_Mock
{
    [TestFixture]
    class LogAnalyzerTest
    {
        [Test]
        public void Analyze_WebServiceThrows_SendsEmail()
        {
            StubService stubService = new StubService();
            stubService.ToThrow = new Exception("fake exception");

            MockEmailService mockEmail = new MockEmailService();
            LogAnalyzer log = new LogAnalyzer();

            //we use setters instead of
            //constructor parameters for easier coding
            log.Service = stubService;
            log.Email = mockEmail;
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);

            Assert.AreEqual("a", mockEmail.To);
            Assert.AreEqual("fake exception", mockEmail.Body);
            Assert.AreEqual("subject", mockEmail.Subject);
        }
    }
}
