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
        public void TestAddWithOtherNumber()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(3, 10);
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void TestAddDoubleWithZero()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(10.0, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestAddDoubleWithNumber()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(10.1, 10);
            Assert.AreEqual(20.1, result);
        }

        [TestMethod]
        public void TestAddDoubleWithMinus()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(-10.0, 10);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAddDoubleWitTwoZero()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(0, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAddDoubleWithMinusWholeNumber()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(-1, 10);
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void TestAddDoubleWithOneZero()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(1, 0);
            Assert.AreEqual(1, result);
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
