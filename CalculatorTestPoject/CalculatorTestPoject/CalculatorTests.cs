using System;
using System.ComponentModel;
using System.Diagnostics;
using CalculatorFunctions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTestPoject
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator _calculator;

        [TestInitialize]
        public void TestInitialize()
        {
            // Arrange
            _calculator = new Calculator();
        }

        #region Test Add
        
        [TestMethod]
        [DataTestMethod]
        [DataRow(-10.1, -10.1, -20.2, DisplayName = "Add negative numbers with value")]
        [DataRow(-10.0, 10.0, 0, DisplayName = "Add negative double number to positive double number")]
        [DataRow(-5.1, 10, 4.9, DisplayName = "Add negative double number with value to positive whole number")]
        [DataRow(-5.0, 10, 5, DisplayName = "Add negative double number to positive whole number")]
        [DataRow(-5, 10, 5, DisplayName = "Add negative number to positive number")]
        [DataRow(-10, 10, 0, DisplayName = "Add negative number to positive number that are the same")]
        [DataRow(10.0, 0, 10, DisplayName = "Add double number to zero")]
        [DataRow(0, 10, 10, DisplayName = "Add positive number to zero")]
        [DataRow(10.0, 10.0, 20, DisplayName = "Add positive double numbers")]
        [DataRow(5, 0.0, 5, DisplayName = "Add positive whole number to double number")]
        [DataRow(5.1, 10, 15.1, DisplayName = "Add positive double number with value to whole number")]
        [DataRow(5.0, 10, 15, DisplayName = "Add positive double number to whole number ")]
        [DataRow(5, 10, 15, DisplayName = "Add positive numbers that are different ")]
        [DataRow(10, 10, 20, DisplayName = "Add positive numbers that are the same")]
        public void Add_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-5, 0, -5, DisplayName = "Add negative number with zero")]
        public void Add_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Add(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion

        #region Test Substact

        [TestMethod]
        [DataTestMethod]
        [DataRow(5, 0.0, 5, DisplayName = "Substact positive whole number to double number")]
        [DataRow(10.0, 0, 10, DisplayName = "Substact double number to zero")]
        [DataRow(10.0, 10.0, 0, DisplayName = "Substact positive double numbers")]
        [DataRow(10, 10, 0, DisplayName = "Substact positive numbers that are the same")]
        public void Substact_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Substact(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataRow(-5.0, 10, -15, DisplayName = "Substact negative double number to positive whole number")]
        [DataRow(-5, 0, -5, DisplayName = "Substact negative number with zero")]
        [DataRow(-10.1, -10.1, -20.2, DisplayName = "Substact negative numbers with value")]
        [DataRow(-5.1, 10, -15.1, DisplayName = "Substact negative double number with value to positive whole number")]
        [DataRow(-5, 10, -15, DisplayName = "Substact negative number to positive number")]
        [DataRow(-10, 10, -20, DisplayName = "Substact negative number to positive number that are the same")]
        [DataRow(5.1, 10, -4.9, DisplayName = "Substact positive double number with value to whole number")]
        [DataRow(5.0, 10, -5, DisplayName = "Substact positive double number to whole number ")]
        [DataRow(0, 10, -10, DisplayName = "Substact positive number to zero")]
        [DataRow(-10.0, 0.0, -10, DisplayName = "Substact negative double number to positive double number")]
        [DataRow(5, 10, -5, DisplayName = "Substact positive numbers that are different ")]
        public void Substact_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Substact(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion

        #region Test Divide

        [TestMethod]
        [DataTestMethod]
        [DataRow(0, 10, 0, DisplayName = "Divide positive number to zero")]
        [DataRow(10.1, 10.1, 1, DisplayName = "Divide negative numbers with value")]
        [DataRow(10.0, 10.0, 1, DisplayName = "Divide positive double numbers")]
        [DataRow(5.1, 10, 0.51, DisplayName = "Divide positive double number with value to whole number")]
        [DataRow(5.0, 10, 0.5, DisplayName = "Divide positive double number to whole number ")]
        [DataRow(5, 10, 0.5, DisplayName = "Divide positive numbers that are different ")]
        [DataRow(10, 10, 1, DisplayName = "Divide positive numbers that are the same")]
        public void Divide_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-10.1, 10.1, -1, DisplayName = "Divide negative double number to positive double number with value")]
        [DataRow(-5.1, 10, -0.51, DisplayName = "Divide negative double number with value to positive whole number")]
        [DataRow(-5.0, 10, -0.5, DisplayName = "Divide negative double number to positive whole number")]
        [DataRow(-5, 10, -0.5, DisplayName = "Divide negative number to positive number")]
        [DataRow(-10, 10, -1, DisplayName = "Divide negative number to positive number that are the same")]
        public void Divide_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Divide(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        [DataTestMethod]
        [DataRow(5, 0.0, DisplayName = "Divide positive whole number to double number")]
        [DataRow(-5, 0, DisplayName = "Divide negative number with zero")]
        [DataRow(10.0, 0, DisplayName = "Divide double number to zero")]
        public void Divide_UserDivideByZero_ThrowsDivideByZeroException(double a, double b)
        {
            try
            {
                // Act
                new Calculator().Divide(a, b);
            }
            catch (DivideByZeroException exception)
            {
                // Assert
                Assert.AreEqual("\aCan not divide by 0", exception.Message);
                throw;
            }
        }

        #endregion
       
        #region Test Multiply
        
        [TestMethod]
        [DataTestMethod]
        [DataRow(5, 0.0, 0, DisplayName = "Multiply positive whole number to double number")]
        [DataRow(-10.0, 0.0, 0, DisplayName = "Multiply negative double number to positive double number")]
        [DataRow(0, 10, 0, DisplayName = "Multiply positive number to zero")]
        [DataRow(-5, 0, 0, DisplayName = "Multiply negative number with zero")]
        [DataRow(10.0, 0, 0, DisplayName = "Multiply double number to zero")]
        [DataRow(5.1, 10, 51, DisplayName = "Multiply positive double number with value to whole number")]
        [DataRow(5.0, 10, 50, DisplayName = "Multiply positive double number to whole number ")]
        [DataRow(5, 10, 50, DisplayName = "Multiply positive numbers that are different ")]
        [DataRow(10, 10, 100, DisplayName = "Multiply positive numbers that are the same")]
        [DataRow(10.0, 10.0, 100, DisplayName = "Multiply positive double numbers")]


        [Ignore("Check test")]
        [DataRow(10.1, 10.1, -102.01, DisplayName = "Multiply positive double numbers with value")]
        [DataRow(-10.1, -10.1, 102.01, DisplayName = "Multiply negative numbers with value")]
        public void Multiply_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow(-10, 10, -100, DisplayName = "Multiply negative number to positive number that are the same")]
        [DataRow(-5, 10, -50, DisplayName = "Multiply negative number to positive number")]
        [DataRow(-5.0, 10, -50, DisplayName = "Multiply negative double number to positive whole number")]
        [DataRow(-5.1, 10, -51, DisplayName = "Multiply negative double number with value to positive whole number")]
        public void Multiply_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [Ignore("Check test")]
        [DataRow(10.1, 10.1, -102.01, DisplayName = "Multiply positive double numbers with value")]
        [DataRow(-10.1, -10.1, 102.01, DisplayName = "Multiply negative numbers with value")]
        public void Multiply_UserMultiplyTwoNonWholeNumbers_ReturnsNegativeNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Multiply(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion

        #region Test Modulo 
        [TestMethod]
        [DataTestMethod]
        [Ignore("Pass test")]
        [DataRow(10, 10, 1, DisplayName = "Modulo positive numbers that are the same")]
        [DataRow(5, 0.0, 0, DisplayName = "Modulo positive whole number to double number")]
        [DataRow(10.0, 0, 0, DisplayName = "Modulo double number to zero")]
        [DataRow(-5, 0, 0, DisplayName = "Modulo negative number with zero")]
        [DataRow(10, 0, 0, DisplayName = "Modulo positive number to Zero")]
        [DataRow(10.1, 10.1, 1.0201, DisplayName = "Modulo negative numbers with value")]
        [DataRow(10.0, 10.0, 1, DisplayName = "Modulo positive double numbers")]
        [DataRow(5.1, 10, 0.51, DisplayName = "Modulo positive double number with value to whole number")]
        [DataRow(5.0, 10, 0.5, DisplayName = "Modulo positive double number to whole number ")]
        [DataRow(5, 10, 0.5, DisplayName = "Modulo positive numbers that are different ")]
        public void Modulo_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Modulo(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [Ignore("Pass Test")]
        [DataRow(-10.1, 10.1, -1.0201, DisplayName = "Modulo negative double number to positive double number with value")]
        [DataRow(-5.1, 10, -0.51, DisplayName = "Modulo negative double number with value to positive whole number")]
        [DataRow(-5.0, 10, -0.5, DisplayName = "Modulo negative double number to positive whole number")]
        [DataRow(-5, 10, -0.5, DisplayName = "Modulo negative number to positive number")]
        [DataRow(-10, 10, -1, DisplayName = "Modulo negative number to positive number that are the same")]
        public void Modulo_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Modulo(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        #endregion

        #region Test Pie
        //[TestMethod]
        //[DataTestMethod]
        //[DataRow(-5.0, 10, 5, DisplayName = "Pie negative double number to positive whole number")]
        //[DataRow(5, 0.0, 5, DisplayName = "Pie positive whole number to double number")]
        //[DataRow(10.0, 0, 10, DisplayName = "Pie double number to zero")]
        //[DataRow(10.0, 10.0, 0, DisplayName = "Pie positive double numbers")]
        //[DataRow(10, 10, 0, DisplayName = "Pie positive numbers that are the same")]

        //[DataRow(-5, 0, -5, DisplayName = "Pie negative number with zero")]
        //[DataRow(-10.1, -10.1, -20.2, DisplayName = "Pie negative numbers with value")]
        //[DataRow(-5.1, 10, -15.1, DisplayName = "Pie negative double number with value to positive whole number")]
        //[DataRow(-5, 10, -15, DisplayName = "Pie negative number to positive number")]
        //[DataRow(-10, 10, -20, DisplayName = "Pie negative number to positive number that are the same")]
        //[DataRow(5.1, 10, -4.9, DisplayName = "Pie positive double number with value to whole number")]
        //[DataRow(5.0, 10, -5, DisplayName = "Pie positive double number to whole number ")]
        //[DataRow(0, 10, -10, DisplayName = "Pie positive number to zero")]
        //[DataRow(-10.0, 0.0, -10, DisplayName = "Pie negative double number to positive double number")]
        //[DataRow(5, 10, -5, DisplayName = "Pie positive numbers that are different ")]


        //public void Pie_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        //{
        //    // Act
        //    var actualResult = _calculator.Pie(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}


        //public void Pie_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        //{
        //    // Act
        //    var actualResult = _calculator.Pie(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}
        #endregion

        #region Test Square Root
        //[TestMethod]
        //[DataTestMethod]
        //[DataRow(-5.0, 10, 5, DisplayName = "Square Root negative double number to positive whole number")]
        //[DataRow(5, 0.0, 5, DisplayName = "Square Root positive whole number to double number")]
        //[DataRow(10.0, 0, 10, DisplayName = "Square Root double number to zero")]
        //[DataRow(10.0, 10.0, 0, DisplayName = "Square Root positive double numbers")]
        //[DataRow(10, 10, 0, DisplayName = "Square Root positive numbers that are the same")]

        //[DataRow(-5, 0, -5, DisplayName = "Square Root negative number with zero")]
        //[DataRow(-10.1, -10.1, -20.2, DisplayName = "Square Root negative numbers with value")]
        //[DataRow(-5.1, 10, -15.1, DisplayName = "Square Root negative double number with value to positive whole number")]
        //[DataRow(-5, 10, -15, DisplayName = "Square Root negative number to positive number")]
        //[DataRow(-10, 10, -20, DisplayName = "Square Root negative number to positive number that are the same")]
        //[DataRow(5.1, 10, -4.9, DisplayName = "Square Root positive double number with value to whole number")]
        //[DataRow(5.0, 10, -5, DisplayName = "Square Root positive double number to whole number ")]
        //[DataRow(0, 10, -10, DisplayName = "Square Root positive number to zero")]
        //[DataRow(-10.0, 0.0, -10, DisplayName = "Square Root negative double number to positive double number")]
        //[DataRow(5, 10, -5, DisplayName = "Square Root positive numbers that are different ")]




        //public void SquareRoot_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        //{
        //    // Act
        //    var actualResult = _calculator.SquareRoot(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}


        //public void SquareRoot_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        //{
        //    // Act
        //    var actualResult = _calculator.SquareRoot(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}

        #endregion

        #region Test Sin
        //[TestMethod]
        //[DataTestMethod]
        //[DataRow(-5.0, 10, 5, DisplayName = "Sin negative double number to positive whole number")]
        //[DataRow(5, 0.0, 5, DisplayName = "Sin positive whole number to double number")]
        //[DataRow(10.0, 0, 10, DisplayName = "Sin double number to zero")]
        //[DataRow(10.0, 10.0, 0, DisplayName = "Sin positive double numbers")]
        //[DataRow(10, 10, 0, DisplayName = "Sin positive numbers that are the same")]

        //[DataRow(-5, 0, -5, DisplayName = "Sin negative number with zero")]
        //[DataRow(-10.1, -10.1, -20.2, DisplayName = "Sin negative numbers with value")]
        //[DataRow(-5.1, 10, -15.1, DisplayName = "Sin negative double number with value to positive whole number")]
        //[DataRow(-5, 10, -15, DisplayName = "Sin negative number to positive number")]
        //[DataRow(-10, 10, -20, DisplayName = "Sin negative number to positive number that are the same")]
        //[DataRow(5.1, 10, -4.9, DisplayName = "Sin positive double number with value to whole number")]
        //[DataRow(5.0, 10, -5, DisplayName = "Sin positive double number to whole number ")]
        //[DataRow(0, 10, -10, DisplayName = "Sin positive number to zero")]
        //[DataRow(-10.0, 0.0, -10, DisplayName = "Sin negative double number to positive double number")]
        //[DataRow(5, 10, -5, DisplayName = "Sin positive numbers that are different ")]



        //public void Sin_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        //{
        //    // Act
        //    var actualResult = _calculator.Sin(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}


        //public void Sin_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        //{
        //    // Act
        //    var actualResult = _calculator.Sin(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}
        #endregion

        #region Test Cos
        //[TestMethod]
        //[DataTestMethod]
        //[DataRow(-5.0, 10, 5, DisplayName = "Cos negative double number to positive whole number")]
        //[DataRow(5, 0.0, 5, DisplayName = "Cos positive whole number to double number")]
        //[DataRow(10.0, 0, 10, DisplayName = "Cos double number to zero")]
        //[DataRow(10.0, 10.0, 0, DisplayName = "Cos positive double numbers")]
        //[DataRow(10, 10, 0, DisplayName = "Cos positive numbers that are the same")]

        //[DataRow(-5, 0, -5, DisplayName = "Cos negative number with zero")]
        //[DataRow(-10.1, -10.1, -20.2, DisplayName = "Cos negative numbers with value")]
        //[DataRow(-5.1, 10, -15.1, DisplayName = "Cos negative double number with value to positive whole number")]
        //[DataRow(-5, 10, -15, DisplayName = "Cos negative number to positive number")]
        //[DataRow(-10, 10, -20, DisplayName = "Cos negative number to positive number that are the same")]
        //[DataRow(5.1, 10, -4.9, DisplayName = "Cos positive double number with value to whole number")]
        //[DataRow(5.0, 10, -5, DisplayName = "Cos positive double number to whole number ")]
        //[DataRow(0, 10, -10, DisplayName = "Cos positive number to zero")]
        //[DataRow(-10.0, 0.0, -10, DisplayName = "Cos negative double number to positive double number")]
        //[DataRow(5, 10, -5, DisplayName = "Cos positive numbers that are different ")]

        //public void Cos_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        //{
        //    // Act
        //    var actualResult = _calculator.Cos(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}


        //public void Cos_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        //{
        //    // Act
        //    var actualResult = _calculator.Cos(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}
        #endregion

        #region Test Tan
        //TestMethod]
        //[DataTestMethod]
        //[DataRow(-5.0, 10, 5, DisplayName = "Tan negative double number to positive whole number")]
        //[DataRow(5, 0.0, 5, DisplayName = "Tan positive whole number to double number")]
        //[DataRow(10.0, 0, 10, DisplayName = "Tan double number to zero")]
        //[DataRow(10.0, 10.0, 0, DisplayName = "Tan positive double numbers")]
        //[DataRow(10, 10, 0, DisplayName = "Tan positive numbers that are the same")]

        //[DataRow(-5, 0, -5, DisplayName = "Tan negative number with zero")]
        //[DataRow(-10.1, -10.1, -20.2, DisplayName = "Tan negative numbers with value")]
        //[DataRow(-5.1, 10, -15.1, DisplayName = "Tan negative double number with value to positive whole number")]
        //[DataRow(-5, 10, -15, DisplayName = "Tan negative number to positive number")]
        //[DataRow(-10, 10, -20, DisplayName = "Tan negative number to positive number that are the same")]
        //[DataRow(5.1, 10, -4.9, DisplayName = "Tan positive double number with value to whole number")]
        //[DataRow(5.0, 10, -5, DisplayName = "Tan positive double number to whole number ")]
        //[DataRow(0, 10, -10, DisplayName = "Tan positive number to zero")]
        //[DataRow(-10.0, 0.0, -10, DisplayName = "Tan negative double number to positive double number")]
        //[DataRow(5, 10, -5, DisplayName = "Tan positive numbers that are different ")]



        //public void Tan_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        //{
        //    // Act
        //    var actualResult = _calculator.Tan(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}


        //public void Tan_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        //{
        //    // Act
        //    var actualResult = _calculator.Tan(a, b);

        //    // Assert
        //    Assert.AreEqual(expectedResult, actualResult);
        //}
        #endregion
    }
}