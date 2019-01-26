using CalculatorFunctions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace CalculatorTestPoject
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator = new Calculator();

        #region Test Add

        public void Add_UserAddPositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(10, 10);

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Add_UserAddDiffPositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(5, 10);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_UserAddDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(5.0, 10);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_UserAddDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(5.1, 10);

            // Assert
            Assert.AreEqual(15.1, result);
        }

        [TestMethod]
        public void Add_UserAddDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(10.0, 10.0);

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Add_UserAddTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(10.10, 10.10);

            // Assert
            Assert.AreEqual(20.2, result);
        }

        [TestMethod]
        public void Add_UserAddPositiveNumberZeroFirst_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(0, 10);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Add_UserAddPositiveNumberZero_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(10.0, 0);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Add_UserAddNegativeNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(-10, 10);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_UserAddDiffNegativeNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(-5, 10);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_UserAddDoubleNegativeNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(-5.0, 10);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_UserAddDiffDoubleNegativeNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(-5.1, 10);

            // Assert
            Assert.AreEqual(4.9, result);
        }

        [TestMethod]
        public void Add_UserAddDoubleNegativeNumberZero_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(-10.0, 10.0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_UserAddDiffTwoDoubleNegativeNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Add(-10.1, 10.1);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_UserAddDiffNegativeNumberWithZero_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Add(-5, 0);

            // Assert
            Assert.AreEqual(-5, result);
        }

        #endregion

        #region Test Substact

        [TestMethod]
        public void Substact_UserSubstactPositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Substact(10, 10);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Substact_UserSubstactDiffPositiveNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Substact(5, 10);

            // Assert
            Assert.AreEqual(-5, result);
        }


        [TestMethod]
        public void Substact_UserSubstactTwoDiffDoublePositiveNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Substact(10.10, 10.10);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Substact_UserSubstactNegativeNumberWithZeroDouble_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Substact(-10, 0.0);

            // Assert
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void Substact_UserSubstactPositiveNumberZeroFirst_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Substact(0, 10);

            // Assert
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void Substact_UserSubstactPositiveNumberZero_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Substact(10.0, 0);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Substact_UserSubstactDoublePositiveNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Substact(5.0, 10);

            // Assert
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Substact_UserSubstactDiffDoublePositiveNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Substact(5.1, 10);

            // Assert
            Assert.AreEqual(-4.9, result);
        }

        [TestMethod]
        public void Substact_UserSubstactDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Substact(10.0, 10.0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Substact_UserSubstactPositiveDoubleNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Substact(5, 0.0);

            // Assert
            Assert.AreEqual(5, result);
        }

        #endregion

        #region Test Multiply

        [TestMethod]
        public void Multiply_UserMultiplyPositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Multiply(10, 10);

            // Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDiffPositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Multiply(5, 10);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Multiply(5.0, 10);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Multiply(5.1, 10);

            // Assert
            Assert.AreEqual(51, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Multiply(10.0, 10.0);

            // Assert
            Assert.AreEqual(100, result);
        }

        //[TestMethod]
        //public void Multiply_UserMultiplyTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Act
        //    var result = _calculator.Multiply(10.10, 10.10);

        //    // Assert
        //    Assert.Equals(102.01, result);
        //}

        [TestMethod]
        public void Multiply_UserMultiplyPositiveNumberZero_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Multiply(10, 0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyNegativeNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Multiply(-10, 10);

            // Assert
            Assert.AreEqual(-100, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDiffNegativeNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Multiply(-5, 10);

            // Assert
            Assert.AreEqual(-50, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Multiply(-5.0, 10);

            // Assert
            Assert.AreEqual(-50, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDiffDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Multiply(-5.1, 10);

            // Assert
            Assert.AreEqual(-51, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDoubleNegativeNumberZero_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Multiply(-10.0, 10.0);

            // Assert
            Assert.AreEqual(-100, result);
        }

        //[TestMethod]
        //public void Multiply_UserMultiplyDiffTwoDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    
        //    

        //    // Act
        //    var result = _calculator.Multiply(10.1, 10.1);

        //    // Assert
        //    Assert.AreEqual(102.01, result);
        //}

        [TestMethod]
        public void Multiply_UserMultiplyNegativeNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Multiply(-5, 0);

            // Assert
            Assert.AreEqual(0, result);
        }

        #endregion

        #region Test Divide

        [TestMethod]
        public void Divide_UserDividePositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Divide(10, 10);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffPositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Divide(5, 10);

            // Assert
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Divide(5.0, 10);

            // Assert
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Divide(5.1, 10);

            // Assert
            Assert.AreEqual(0.51, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Divide(10.0, 10.0);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod] //Check
        public void Divide_UserDivideTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Divide(10.10, 10.10);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Divide_UserDividePositiveNumberZeroFirst_ReturnsPositiveNumber()
        {
            // Act
            var result = _calculator.Divide(0, 10);

            // Assert
            Assert.AreEqual(0, result);
        }

        //[TestMethod]
        //public void Divide_UserDividePositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    
        //    

        //    // Act
        //    var result = _calculator.DivideByZero(10.0, 0);

        //    // Assert
        //    Assert.Fail("Can not divide by 0", result);
        //    Assert.ThrowsException<string>()
        //    Assert.AreEqual(10, result);
        //    Return //Can not divide by 0
        //}

        [TestMethod]
        public void Divide_UserDivideNegativeNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Divide(-10, 10);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffNegativeNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Divide(-5, 10);

            // Assert
            Assert.AreEqual(-0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Divide(-5.0, 10);

            // Assert
            Assert.AreEqual(-0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Divide(-5.1, 10);

            // Assert
            Assert.AreEqual(-0.51, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoubleNegativeNumberZero_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Divide(-10.0, 10.0);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffTwoDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            // Act
            var result = _calculator.Divide(-10.1, 10.1);

            // Assert
            Assert.AreEqual(-1, result);
        }

        //[TestMethod]
        //public void Divide_UserDivideNegativeNumber_ReturnsPositiveNumber()
        //{
        //    
        //    

        //    // Act
        //    var result = _calculator.Divide(-5, 0);

        //    // Assert
        //    Assert.AreEqual(-5, result);
        //}

        #endregion

        #region Test Modulo 

        //[TestMethod]
        //public void Modulo_UserModuloPositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(10, 10);

        //    // Assert
        //    Assert.AreEqual(1, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffPositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(5, 10);

        //    // Assert
        //    Assert.AreEqual(0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(5.0, 10);

        //    // Assert
        //    Assert.AreEqual(0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(5.1, 10);

        //    // Assert
        //    Assert.AreEqual(0.51, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoublePositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(10.0, 10.0);

        //    // Assert
        //    Assert.AreEqual(1, result);
        //}

        //[TestMethod] //Check
        //public void Modulo_UserModuloTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(10.10, 10.10);

        //    // Assert
        //    Assert.AreEqual(1.0201, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloPositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(10, 0);

        //    // Assert
        //    Assert.AreEqual(0, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(-10, 10);

        //    // Assert
        //    Assert.AreEqual(-1, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(-5, 10);

        //    // Assert
        //    Assert.AreEqual(-0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(-5.0, 10);

        //    // Assert
        //    Assert.AreEqual(-0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(-5.1, 10);

        //    // Assert
        //    Assert.AreEqual(-0.51, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoubleNegativeNumberZero_ReturnsNegativeNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(-10.0, 10.0);

        //    // Assert
        //    Assert.AreEqual(-1, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffTwoDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(-10.1, 10.1);

        //    // Assert
        //    Assert.AreEqual(-1.0201, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloNegativeNumber_ReturnsPositiveNumber()
        //{
        //    // Act
        //    var result = _calculator.Modulo(-5, 0);

        //    // Assert
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