using System;
using NUnit.Framework;

namespace DevOpsDemoTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void DemoTestMethod()
        {
            //Test Comment
            Assert.AreEqual(1, 1);
        }
    }
}
