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
            var result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestAddDiffPostitionWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(5, 10);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestAddPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(5.0, 10);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void TestAddDiffPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(5.1, 10);
            Assert.AreEqual(15.1, result);
        }

        [TestMethod]
        public void TestAddTwoPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(10.0, 10.0);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestAddTwoDiffPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(10.1, 10.1);
            Assert.AreEqual(20.2, result);
        }

        [TestMethod]
        public void TestAddPostitionNumberWithZero()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(10, 0);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestAddNegativeWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-10, 10);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAddDiffNegativeWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-5, 10);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestAddNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-5.0, 10);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestAddDiffNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-5.1, 10);
            Assert.AreEqual(4.9, result);
        }

        [TestMethod]
        public void TestAddTwoNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-10.0, 10.0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAddTwoDiffNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-10.1, 10.1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAddNegativeNumberWithZero()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-5, 0);
            Assert.AreEqual(-5, result);
        }

        #endregion

        #region Test Substact

        [TestMethod]
        public void TestSubstactPostitionWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(10, 10);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSubstactDiffPostitionWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(-5, 10);
            Assert.AreEqual(-15, result);
        }

        [TestMethod]
        public void TestSubstactPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(-5.0, 10);
            Assert.AreEqual(-15, result);
        }

        [TestMethod]
        public void TestSubstactDiffPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(-5.1, 10);
            Assert.AreEqual(-15.1, result);
        }

        [TestMethod]
        public void TestSubstactTwoPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(-10.0, 10.0);
            Assert.AreEqual(-20, result);
        }

        [TestMethod]
        public void TestSubstactTwoDiffPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(-10.1, 10.1);
            Assert.AreEqual(-20.2, result);
        }

        [TestMethod]
        public void TestSubstactPostitionNumberWithZero()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(-10, 0.0);
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void TestSubstactNegativeWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(+10, 10);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSubstactDiffNegativeWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(+5, 10);
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void TestSubstactNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(+5.0, 10);
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void TestSubstactDiffNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(+5.1, 10);
            Assert.AreEqual(-4.9, result);
        }

        [TestMethod]
        public void TestSubstactTwoNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(10.0, 10.0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSubstactTwoDiffNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(10.1, 10.1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestSubstactNegativeNumberWithZero()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(5, 0.0);
            Assert.AreEqual(5, result);
        }






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
