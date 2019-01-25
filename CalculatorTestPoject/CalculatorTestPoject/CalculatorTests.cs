using System;
using CalculatorFunctions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTestPoject
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestAddDefault()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestAddDoubleWithZero()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(10.0, 10);
            Assert.AreEqual(20, result);
        }

        //[TestMethod]
        //public void TestSubstact()
        //{
        //    Calculator obj = new Calculator();
        //    decimal result = obj.Substact(10, 10);
        //    Assert.AreEqual(20, result);
        //}


    }
}
