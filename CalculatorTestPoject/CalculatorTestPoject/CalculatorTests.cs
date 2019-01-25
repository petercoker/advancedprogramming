using System;
using CalculatorFunctions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTestPoject
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator obj = new Calculator();
            decimal result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }
    }
}
