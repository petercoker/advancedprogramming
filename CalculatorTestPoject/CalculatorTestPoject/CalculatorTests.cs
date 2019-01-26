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
        [TestMethod]
        public void TestDividePostitionWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(10, 10);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestDivideDiffPostitionWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(5, 10);
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void TestDividePostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(5.0, 10);
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void TestDivideDiffPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(5.1, 10);
            Assert.AreEqual(0.51, result);
        }

        [TestMethod]
        public void TestDivideTwoPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(10.0, 10.0);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestDivideTwoDiffPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(10.1, 10.1);
            Assert.AreEqual(1, result);
        }

        public void TestDividePostitionNumberWithZeroFirst()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(0, 10);
            Assert.AreEqual(10, result);
        }

        //[TestMethod]
        //public void TestDividePostitionNumberWithZero()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.DivideByZero(10.0, 0);
        //    Assert.Fail("Can not divide by 0", result);
        //    Assert.ThrowsException<string>()
        //    Assert.AreEqual(10, result);
        //    Return //Can not divide by 0
        //}

        [TestMethod]
        public void TestDivideNegativeWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-10, 10);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestDivideDiffNegativeWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-5, 10);
            Assert.AreEqual(-0.5, result);
        }

        [TestMethod]
        public void TestDivideNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-5.0, 10);
            Assert.AreEqual(-0.5, result);
        }

        [TestMethod]
        public void TestDivideDiffNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-5.1, 10);
            Assert.AreEqual(-0.51, result);
        }

        [TestMethod]
        public void TestDivideTwoNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-10.0, 10.0);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void TestDivideTwoDiffNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-10.1, 10.1);
            Assert.AreEqual(-1, result);
        }

        //[TestMethod] //Throw expect
        //public void TestDivideNegativeNumberWithZero()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Divide(-5, 0);
        //    Assert.AreEqual(-5, result);
        //}

        #endregion

        #region Test Multiply


        [TestMethod]
        public void TestMutliplyPostitionWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(10, 10);
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void TestMutliplyDiffPostitionWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(5, 10);
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestMutliplyPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(5.0, 10);
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void TestMutliplyDiffPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(5.1, 10);
            Assert.AreEqual(51, result);
        }

        [TestMethod]
        public void TestMutliplyTwoPostitionVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(10.0, 10.0);
            Assert.AreEqual(100, result);
        }

        //[TestMethod]
        //public void TestMutliplyTwoDiffPostitionVarNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Mutliply(10.1, 10.1);
        //    Assert.AreEqual(102.01, result);
        //}

        [TestMethod]
        public void TestMutliplyPostitionNumberWithZero()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(10, 0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMutliplyNegativeWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(-10, 10);
            Assert.AreEqual(-100, result);
        }

        [TestMethod]
        public void TestMutliplyDiffNegativeWholeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(-5, 10);
            Assert.AreEqual(-50, result);
        }

        [TestMethod]
        public void TestMutliplyNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(-5.0, 10);
            Assert.AreEqual(-50, result);
        }

        [TestMethod]
        public void TestMutliplyDiffNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(-5.1, 10);
            Assert.AreEqual(-51, result);
        }

        [TestMethod]
        public void TestMutliplyTwoNegativeVarNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Mutliply(-10.0, 10.0);
            Assert.AreEqual(-100, result);
        }

        //[TestMethod]
        //public void TestMutliplyTwoDiffNegativeVarNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Mutliply(-10.1, 10.1);
        //    Assert.AreEqual(-102.01, result);
        //}

        //[TestMethod]
        //public void TestMutliplyNegativeNumberWithZero()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Mutliply(-5, 0);
        //    Assert.AreEqual(0, result);
        //}




        #endregion

        #region Test Modulus 

        //[TestMethod]
        //public void TestModuloPostitionWholeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(10, 10);
        //    Assert.AreEqual(1, result);
        //}

        //[TestMethod]
        //public void TestModuloDiffPostitionWholeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(5, 10);
        //    Assert.AreEqual(0.5, result);
        //}

        //[TestMethod]
        //public void TestModuloPostitionVarNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(5.0, 10);
        //    Assert.AreEqual(0.5, result);
        //}

        //[TestMethod]
        //public void TestModuloDiffPostitionVarNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(5.1, 10);
        //    Assert.AreEqual(0.51, result);
        //}

        //[TestMethod]
        //public void TestModuloTwoPostitionVarNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(10.0, 10.0);
        //    Assert.AreEqual(1, result);
        //}

        //[TestMethod]
        //public void TestModuloTwoDiffPostitionVarNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(10.1, 10.1);
        //    Assert.AreEqual(1.0201, result);
        //}

        //[TestMethod]
        //public void TestModuloPostitionNumberWithZero()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(10, 0);
        //    Assert.AreEqual(0, result);
        //}

        //[TestMethod]
        //public void TestModuloNegativeWholeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-10, 10);
        //    Assert.AreEqual(-1, result);
        //}

        //[TestMethod]
        //public void TestModuloDiffNegativeWholeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-5, 10);
        //    Assert.AreEqual(-0.5, result);
        //}

        //[TestMethod]
        //public void TestModuloNegativeVarNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-5.0, 10);
        //    Assert.AreEqual(-0.5, result);
        //}

        //[TestMethod]
        //public void TestModuloDiffNegativeVarNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-5.1, 10);
        //    Assert.AreEqual(-0.51, result);
        //}

        //[TestMethod]
        //public void TestModuloTwoNegativeVarNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-10.0, 10.0);
        //    Assert.AreEqual(-1, result);
        //}

        //[TestMethod]
        //public void TestModuloTwoDiffNegativeVarNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-10.1, 10.1);
        //    Assert.AreEqual(-1.0201, result);
        //}

        //[TestMethod]
        //public void TestModuloNegativeNumberWithZero()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-5, 0);
        //    Assert.AreEqual(0, result);
        //}
        
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
