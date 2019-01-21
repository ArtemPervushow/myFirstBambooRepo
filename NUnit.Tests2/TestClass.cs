using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit.Tests2
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            Assert.Pass("Your first passing test");
            Assert.AreEqual(4, Calculator.plus(2,2));
        }
    }
}
