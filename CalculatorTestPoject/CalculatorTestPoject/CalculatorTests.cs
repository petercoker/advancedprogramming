using System;
using CalculatorFunctions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTestPoject
{
    [TestClass]
    public class CalculatorTests
    {
        #region Test Add
        [TestMethod]
        public void Add_UserAddPositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(10, 10);
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Add_UserAddDiffPositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(5, 10);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_UserAddDoublePositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(5.0, 10);
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_UserAddDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(5.1, 10);
            Assert.AreEqual(15.1, result);
        }

        [TestMethod]
        public void Add_UserAddDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(10.0, 10.0);
            Assert.AreEqual(20, result);
        }

        [TestMethod] //Check
        public void Add_UserAddTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(10.10, 10.10);
            Assert.AreEqual(20.2, result);
        }

        [TestMethod]
        public void Add_UserAddPositiveNumberZeroFirst_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(0, 10);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Add_UserAddPositiveNumberZero_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(10.0, 0);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Add_UserAddNegativeNumber_ReturnsPositiveNumber()

        {
            Calculator obj = new Calculator();
            var result = obj.Add(-10, 10);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_UserAddDiffNegativeNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-5, 10);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_UserAddDoubleNegativeNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-5.0, 10);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_UserAddDiffDoubleNegativeNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-5.1, 10);
            Assert.AreEqual(4.9, result);
        }

        [TestMethod]
        public void Add_UserAddDoubleNegativeNumberZero_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-10.0, 10.0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_UserAddDiffTwoDoubleNegativeNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-10.1, 10.1);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_UserAddDiffNegativeNumberWithZero_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Add(-5, 0);
            Assert.AreEqual(-5, result);
        }




        #endregion

        #region Test Substact

        [TestMethod]
        public void Substact_UserSubstactPositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(10, 10);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Substact_UserSubstactDiffPositiveNumber_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(5, 10);
            Assert.AreEqual(-5, result);
        }
        

        [TestMethod]
        public void Substact_UserSubstactTwoDiffDoublePositiveNumber_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(10.10, 10.10);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Substact_UserSubstactNegativeNumberWithZeroDouble_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(-10, 0.0);
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void Substact_UserSubstactPositiveNumberZeroFirst_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(0, 10);
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void Substact_UserSubstactPositiveNumberZero_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(10.0, 0);
            Assert.AreEqual(10, result);
        }
        

        [TestMethod]
        public void Substact_UserSubstactDoublePositiveNumber_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(5.0, 10);
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Substact_UserSubstactDiffDoublePositiveNumber_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(5.1, 10);
            Assert.AreEqual(-4.9, result);
        }

        [TestMethod]
        public void Substact_UserSubstactDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(10.0, 10.0);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Substact_UserSubstactPositiveDoubleNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Substact(5, 0.0);
            Assert.AreEqual(5, result);
        }

        #endregion

        #region Test Divide

        [TestMethod]
        public void Divide_UserDividePositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(10, 10);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffPositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(5, 10);
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoublePositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(5.0, 10);
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(5.1, 10);
            Assert.AreEqual(0.51, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(10.0, 10.0);
            Assert.AreEqual(1, result);
        }

        [TestMethod] //Check
        public void Divide_UserDivideTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(10.10, 10.10);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Divide_UserDividePositiveNumberZeroFirst_ReturnsPositiveNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(0, 10);
            Assert.AreEqual(0, result);
        }

        //[TestMethod]
        //public void Divide_UserDividePositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.DivideByZero(10.0, 0);
        //    Assert.Fail("Can not divide by 0", result);
        //    Assert.ThrowsException<string>()
        //    Assert.AreEqual(10, result);
        //    Return //Can not divide by 0
        //}

        [TestMethod]
        public void Divide_UserDivideNegativeNumber_ReturnsNegativeNumber()

        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-10, 10);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffNegativeNumber_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-5, 10);
            Assert.AreEqual(-0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-5.0, 10);
            Assert.AreEqual(-0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-5.1, 10);
            Assert.AreEqual(-0.51, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoubleNegativeNumberZero_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-10.0, 10.0);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffTwoDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            Calculator obj = new Calculator();
            var result = obj.Divide(-10.1, 10.1);
            Assert.AreEqual(-1, result);
        }

        //[TestMethod]
        //public void Divide_UserDivideNegativeNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Divide(-5, 0);
        //    Assert.AreEqual(-5, result);
        //}


        #endregion

        #region Test Multiply

        //[TestMethod]
        //public void Multiply_UserMultiplyPositiveNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(10, 10);
        //    Assert.AreEqual(100, result);
        //}

        //[TestMethod]
        //public void Multiply_UserMultiplyDiffPositiveNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(5, 10);
        //    Assert.AreEqual(50, result);
        //}

        //[TestMethod]
        //public void Multiply_UserMultiplyDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(5.0, 10);
        //    Assert.AreEqual(50, result);
        //}

        //[TestMethod]
        //public void Multiply_UserMultiplyDiffDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(5.1, 10);
        //    Assert.AreEqual(51, result);
        //}

        //[TestMethod]
        //public void Multiply_UserMultiplyDoublePositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(10.0, 10.0);
        //    Assert.AreEqual(100, result);
        //}

        //[TestMethod] //Check
        //public void Multiply_UserMultiplyTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(10.10, 10.10);
        //    Assert.AreEqual(102.01, result);
        //}

        //[TestMethod]
        //public void Multiply_UserMultiplyPositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(10, 0);
        //    Assert.AreEqual(0, result);
        //}

        //[TestMethod]
        //public void Multiply_UserMultiplyNegativeNumber_ReturnsNegativeNumber()

        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(-10, 10);
        //    Assert.AreEqual(-100, result);
        //}

        //[TestMethod]
        //public void Multiply_UserMultiplyDiffNegativeNumber_ReturnsNegativeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(-5, 10);
        //    Assert.AreEqual(-50, result);
        //}

        //[TestMethod]
        //public void Multiply_UserMultiplyDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(-5.0, 10);
        //    Assert.AreEqual(-50, result);
        //}

        //[TestMethod]
        //public void Multiply_UserMultiplyDiffDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(-5.1, 10);
        //    Assert.AreEqual(-51, result);
        //}

        //[TestMethod]
        //public void Multiply_UserMultiplyDoubleNegativeNumberZero_ReturnsNegativeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Multiply(-10.0, 10.0);
        //    Assert.AreEqual(-100, result);
        //}

        ////[TestMethod]
        ////public void Multiply_UserMultiplyDiffTwoDoubleNegativeNumber_ReturnsNegativeNumber()
        ////{
        ////    Calculator obj = new Calculator();
        ////    var result = obj.Multiply(-10.1, 10.1);
        ////    Assert.AreEqual(-102.01, result);
        ////}

        ////[TestMethod]
        ////public void Multiply_UserMultiplyNegativeNumber_ReturnsPositiveNumber()
        ////{
        ////    Calculator obj = new Calculator();
        ////    var result = obj.Multiply(-5, 0);
        ////    Assert.AreEqual(0, result);
        ////}

        #endregion

        #region Test Modulo 

        //[TestMethod]
        //public void Modulo_UserModuloPositiveNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(10, 10);
        //    Assert.AreEqual(1, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffPositiveNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(5, 10);
        //    Assert.AreEqual(0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(5.0, 10);
        //    Assert.AreEqual(0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(5.1, 10);
        //    Assert.AreEqual(0.51, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoublePositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(10.0, 10.0);
        //    Assert.AreEqual(1, result);
        //}

        //[TestMethod] //Check
        //public void Modulo_UserModuloTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(10.10, 10.10);
        //    Assert.AreEqual(1.0201, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloPositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(10, 0);
        //    Assert.AreEqual(0, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloNegativeNumber_ReturnsNegativeNumber()

        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-10, 10);
        //    Assert.AreEqual(-1, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffNegativeNumber_ReturnsNegativeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-5, 10);
        //    Assert.AreEqual(-0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-5.0, 10);
        //    Assert.AreEqual(-0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-5.1, 10);
        //    Assert.AreEqual(-0.51, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoubleNegativeNumberZero_ReturnsNegativeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-10.0, 10.0);
        //    Assert.AreEqual(-1, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffTwoDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    Calculator obj = new Calculator();
        //    var result = obj.Modulo(-10.1, 10.1);
        //    Assert.AreEqual(-1.0201, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloNegativeNumber_ReturnsPositiveNumber()
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
