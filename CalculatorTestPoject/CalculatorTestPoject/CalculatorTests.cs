using System;
using System.Globalization;
using CalculatorFunctions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTestPoject
{
    [TestClass]
    public class CalculatorTests
    {
        #region Test Add

        [TestMethod]
        public void TestAddPostitionWholeNumber()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestAddDiffPostitionWholeNumber()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(5, 10);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestAddPostitionDoubleNumber()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(5.0, 10);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestAddDiffPostitionDoubleNumber()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(5.1, 10);
            Assert.AreEqual(15.1, result);
        }

        [TestMethod]
        public void TestAddTwoPostitionDoubleNumber()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(10.0, 10.0);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestAddTwoDiffPostitionDoubleNumber()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(10.1, 10.1);
            Assert.AreEqual(20.2, result);
        }

        [TestMethod]
        public void TestAddPostitionNumberWithZero()
        {
            Calculator obj = new Calculator();
            double result = obj.Add(10, 0);
            Assert.AreEqual(10, result);
        }








        #endregion

        #region Test Substact

        
        #endregion

        #region Test Divide



        #endregion

        #region Test Multiply




        #endregion

        #region Test Modulus 



        #endregion

        #region Test Pie



        #endregion

        #region Test Square Root



        #endregion

        #region Test Sin



        #endregion

        #region Test Cos



        #endregion

        #region Test Tan

        

        #endregion

    }
}
