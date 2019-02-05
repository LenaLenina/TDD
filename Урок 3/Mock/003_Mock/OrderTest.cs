using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;

namespace _003_Mock
{
    [TestFixture]
    class OrderTest
    {
        [Test]
        public void TestFillingOrderWithRhinoStub()
        {
            Order order = new Order("Keyboard");
            var stubUserRepository = MockRepository.GenerateStub<Warehouse>();

            stubUserRepository.Stub(x => x.HasInventory("Keyboard")).Return(true);
            stubUserRepository.Stub(x => x.Remove("Keyboard"));

            order.Fill(stubUserRepository);
            Assert.IsTrue(order.IsFilled);
        }
    }
}
