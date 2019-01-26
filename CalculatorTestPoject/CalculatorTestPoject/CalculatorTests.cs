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
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(10, 10);

            // Assert
            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void Add_UserAddDiffPositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(5, 10);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_UserAddDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(5.0, 10);

            // Assert
            Assert.AreEqual(15, result);
        }

        [TestMethod]
        public void Add_UserAddDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(5.1, 10);

            // Assert
            Assert.AreEqual(15.1, result);
        }

        [TestMethod]
        public void Add_UserAddDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(10.0, 10.0);

            // Assert
            Assert.AreEqual(20, result);

        }

        [TestMethod] 
        public void Add_UserAddTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(10.10, 10.10);

            // Assert
            Assert.AreEqual(20.2, result);

        }

        [TestMethod]
        public void Add_UserAddPositiveNumberZeroFirst_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(0, 10);

            // Assert
            Assert.AreEqual(10, result);

        }

        [TestMethod]
        public void Add_UserAddPositiveNumberZero_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(10.0, 0);

            // Assert
            Assert.AreEqual(10, result);

        }

        [TestMethod]
        public void Add_UserAddNegativeNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(-10, 10);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_UserAddDiffNegativeNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(-5, 10);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_UserAddDoubleNegativeNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(-5.0, 10);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Add_UserAddDiffDoubleNegativeNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(-5.1, 10);

            // Assert
            Assert.AreEqual(4.9, result);
        }

        [TestMethod]
        public void Add_UserAddDoubleNegativeNumberZero_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(-10.0, 10.0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_UserAddDiffTwoDoubleNegativeNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(-10.1, 10.1);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Add_UserAddDiffNegativeNumberWithZero_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Add(-5, 0);

            // Assert
            Assert.AreEqual(-5, result);
        }
        
        #endregion

        #region Test Substact

        [TestMethod]
        public void Substact_UserSubstactPositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Substact(10, 10);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Substact_UserSubstactDiffPositiveNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Substact(5, 10);

            // Assert
            Assert.AreEqual(-5, result);
        }
        

        [TestMethod]
        public void Substact_UserSubstactTwoDiffDoublePositiveNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Substact(10.10, 10.10);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Substact_UserSubstactNegativeNumberWithZeroDouble_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Substact(-10, 0.0);

            // Assert
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void Substact_UserSubstactPositiveNumberZeroFirst_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Substact(0, 10);

            // Assert
            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void Substact_UserSubstactPositiveNumberZero_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Substact(10.0, 0);

            // Assert
            Assert.AreEqual(10, result);
        }
        
        [TestMethod]
        public void Substact_UserSubstactDoublePositiveNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Substact(5.0, 10);

            // Assert
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Substact_UserSubstactDiffDoublePositiveNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Substact(5.1, 10);

            // Assert
            Assert.AreEqual(-4.9, result);
        }

        [TestMethod]
        public void Substact_UserSubstactDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Substact(10.0, 10.0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Substact_UserSubstactPositiveDoubleNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Substact(5, 0.0);

            // Assert
            Assert.AreEqual(5, result);
        }

        #endregion

        #region Test Multiply

        [TestMethod]
        public void Multiply_UserMultiplyPositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(10, 10);

            // Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDiffPositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(5, 10);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(5.0, 10);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(5.1, 10);

            // Assert
            Assert.AreEqual(51, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(10.0, 10.0);

            // Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(10.10, 10.10);

            // Assert
            Assert.AreEqual(102.01, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyPositiveNumberZero_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(10, 0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(-10, 10);

            // Assert
            Assert.AreEqual(-100, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDiffNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(-5, 10);

            // Assert
            Assert.AreEqual(-50, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(-5.0, 10);

            // Assert
            Assert.AreEqual(-50, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDiffDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(-5.1, 10);

            // Assert
            Assert.AreEqual(-51, result);
        }

        [TestMethod]
        public void Multiply_UserMultiplyDoubleNegativeNumberZero_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(-10.0, 10.0);

            // Assert
            Assert.AreEqual(-100, result);
        }

        //[TestMethod]
        //public void Multiply_UserMultiplyDiffTwoDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Multiply(10.1, 10.1);

        //    // Assert
        //    Assert.AreEqual(102.01, result);
        //}

        [TestMethod]
        public void Multiply_UserMultiplyNegativeNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Multiply(-5, 0);

            // Assert
            Assert.AreEqual(0, result);
        }

        #endregion

        #region Test Divide

        [TestMethod]
        public void Divide_UserDividePositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(10, 10);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffPositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(5, 10);

            // Assert
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(5.0, 10);

            // Assert
            Assert.AreEqual(0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(5.1, 10);

            // Assert
            Assert.AreEqual(0.51, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoublePositiveNumberZero_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(10.0, 10.0);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod] //Check
        public void Divide_UserDivideTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(10.10, 10.10);

            // Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Divide_UserDividePositiveNumberZeroFirst_ReturnsPositiveNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(0, 10);

            // Assert
            Assert.AreEqual(0, result);
        }

        //[TestMethod]
        //public void Divide_UserDividePositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.DivideByZero(10.0, 0);

        //    // Assert
        //    Assert.Fail("Can not divide by 0", result);
        //    Assert.ThrowsException<string>()
        //    Assert.AreEqual(10, result);
        //    Return //Can not divide by 0
        //}

        [TestMethod]
        public void Divide_UserDivideNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(-10, 10);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(-5, 10);

            // Assert
            Assert.AreEqual(-0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(-5.0, 10);

            // Assert
            Assert.AreEqual(-0.5, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(-5.1, 10);

            // Assert
            Assert.AreEqual(-0.51, result);
        }

        [TestMethod]
        public void Divide_UserDivideDoubleNegativeNumberZero_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(-10.0, 10.0);

            // Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void Divide_UserDivideDiffTwoDoubleNegativeNumber_ReturnsNegativeNumber()
        {
            // Arrange
            Calculator obj = new Calculator();

            // Act
            var result = obj.Divide(-10.1, 10.1);

            // Assert
            Assert.AreEqual(-1, result);
        }

        //[TestMethod]
        //public void Divide_UserDivideNegativeNumber_ReturnsPositiveNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Divide(-5, 0);

        //    // Assert
        //    Assert.AreEqual(-5, result);
        //}


        #endregion

        #region Test Modulo 

        //[TestMethod]
        //public void Modulo_UserModuloPositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(10, 10);

        //    // Assert
        //    Assert.AreEqual(1, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffPositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(5, 10);

        //    // Assert
        //    Assert.AreEqual(0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(5.0, 10);

        //    // Assert
        //    Assert.AreEqual(0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(5.1, 10);

        //    // Assert
        //    Assert.AreEqual(0.51, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoublePositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(10.0, 10.0);

        //    // Assert
        //    Assert.AreEqual(1, result);
        //}

        //[TestMethod] //Check
        //public void Modulo_UserModuloTwoDiffDoublePositiveNumber_ReturnsPositiveNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(10.10, 10.10);

        //    // Assert
        //    Assert.AreEqual(1.0201, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloPositiveNumberZero_ReturnsPositiveNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(10, 0);

        //    // Assert
        //    Assert.AreEqual(0, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(-10, 10);

        //    // Assert
        //    Assert.AreEqual(-1, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(-5, 10);

        //    // Assert
        //    Assert.AreEqual(-0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(-5.0, 10);

        //    // Assert
        //    Assert.AreEqual(-0.5, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(-5.1, 10);

        //    // Assert
        //    Assert.AreEqual(-0.51, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDoubleNegativeNumberZero_ReturnsNegativeNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(-10.0, 10.0);

        //    // Assert
        //    Assert.AreEqual(-1, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloDiffTwoDoubleNegativeNumber_ReturnsNegativeNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(-10.1, 10.1);

        //    // Assert
        //    Assert.AreEqual(-1.0201, result);
        //}

        //[TestMethod]
        //public void Modulo_UserModuloNegativeNumber_ReturnsPositiveNumber()
        //{
        //    // Arrange
        //    Calculator obj = new Calculator();

        //    // Act
        //    var result = obj.Modulo(-5, 0);

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
