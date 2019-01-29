using System;
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
        [DataRow(-10.1, -10.1, -20, DisplayName = "Add negative numbers with value")]
        [DataRow(-10.0, 10.0, 0, DisplayName = "Add negative double number to positive double number")]
        [DataRow(-5.1, 10, 5, DisplayName = "Add negative double number with value to positive whole number")]
        [DataRow(-5.0, 10, 5, DisplayName = "Add negative double number to positive whole number")]
        [DataRow(-5, 10, 5, DisplayName = "Add negative number to positive number")]
        [DataRow(-10, 10, 0, DisplayName = "Add negative number to positive number that are the same")]
        [DataRow(10.0, 0, 10, DisplayName = "Add double number to zero")]
        [DataRow(0, 10, 10, DisplayName = "Add positive number to zero")]
        [DataRow(10.0, 10.0, 20, DisplayName = "Add positive double numbers")]
        [DataRow(5, 0.0, 5, DisplayName = "Add positive whole number to double number")]
        [DataRow(5.1, 10, 15, DisplayName = "Add positive double number with value to whole number")]
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
        [DataRow(5, 0.0, 5, DisplayName = "Subtract positive whole number to double number")]
        [DataRow(10.0, 0, 10, DisplayName = "Subtract double number to zero")]
        [DataRow(10.0, 10.0, 0, DisplayName = "Subtract positive double numbers")]
        [DataRow(10, 10, 0, DisplayName = "Subtract positive numbers that are the same")]
        public void Subtract_WhenCalled_ReturnsPositiveNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Substract(a, b);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [DataRow(-5.0, 10, -15, DisplayName = "Subtract negative double number to positive whole number")]
        [DataRow(-5, 0, -5, DisplayName = "Subtract negative number with zero")]
        [DataRow(-10.1, -10.1, -20, DisplayName = "Subtract negative numbers with value")]
        [DataRow(-5.1, 10, -15, DisplayName = "Subtract negative double number with value to positive whole number")]
        [DataRow(-5, 10, -15, DisplayName = "Subtract negative number to positive number")]
        [DataRow(-10, 10, -20, DisplayName = "Subtract negative number to positive number that are the same")]
        [DataRow(5.1, 10, -5, DisplayName = "Subtract positive double number with value to whole number")]
        [DataRow(5.0, 10, -5, DisplayName = "Subtract positive double number to whole number ")]
        [DataRow(0, 10, -10, DisplayName = "Subtract positive number to zero")]
        [DataRow(-10.0, 0.0, -10, DisplayName = "Subtract negative double number to positive double number")]
        [DataRow(5, 10, -5, DisplayName = "Subtract positive numbers that are different ")]
        public void Subtract_WhenCalled_ReturnsNegativeNumber(double a, double b, double expectedResult)
        {
            // Act
            var actualResult = _calculator.Substract(a, b);

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
        [DataRow(5.1, 10, 1, DisplayName = "Divide positive double number with value to whole number")]
        [DataRow(5.0, 10, 0, DisplayName = "Divide positive double number to whole number ")]
        [DataRow(5, 10, 0, DisplayName = "Divide positive numbers that are different ")]
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
        [DataRow(-5.1, 10, -1, DisplayName = "Divide negative double number with value to positive whole number")]
        [DataRow(-5.0, 10, 0, DisplayName = "Divide negative double number to positive whole number")]
        [DataRow(-5, 10, 0, DisplayName = "Divide negative number to positive number")]
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
        [DataRow(10.1, 10.1, 102, DisplayName = "Multiply positive double numbers with value")]
        [DataRow(-10.1, -10.1, 102, DisplayName = "Multiply negative numbers with value")]
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
        #endregion

        #region Test Square Root

        [TestMethod]
        [DataTestMethod]
        [DataRow(5.0, 2, DisplayName = "Square Root different positive double number with no value")]
        [DataRow(0, 0, DisplayName = "Square Root positive zero whole number")]
        [DataRow(5, 2, DisplayName = "Square Root different positive number")]
        [DataRow(0.0, 0, DisplayName = "Square Root positive zero double number with no value")]
        [DataRow(10, 3, DisplayName = "Square Root positive whole number")]
        [DataRow(5.1, 2, DisplayName = "Square Root positive double number with value")]
        [DataRow(10.0, 3, DisplayName = "Square Root positive double number with no zero")]
        public void SquareRoot_WhenCalled_ReturnsPositiveNumber(double a, double expectedResult)
        {
            // Act
            var actualResult = _calculator.GetSquareRoot(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))] //Look at a better expection
        
        [DataTestMethod]
        [DataRow(-5.0, DisplayName = "Square Root negative double number with no value")]
        [DataRow(-10.1, DisplayName = "Square Root negative double number with value")]
        [DataRow(-5.1, DisplayName = "Square Root different negative double number with value")]
        [DataRow(-5, DisplayName = "Square Root negative whole number")]
        [DataRow(-10, DisplayName = "Square Root different negative number")]
        [DataRow(-10.0, DisplayName = "Square Root negative double number with no value")]
        public void SquareRoot_UserGetSquareOfNegativeNumber_ThrowsException(double a)
        {
            // Act
            new Calculator().GetSquareRoot(a);
        }

        #endregion

        #region Test Sin

        [TestMethod]
        [DataTestMethod]
        [Ignore("check")]
        [DataRow(5.0, -0.958924274663138, DisplayName = "Sin different positive double number with no value")]
        [DataRow(0, 0, DisplayName = "Sin positive zero whole number")]
        [DataRow(5, 0.08715574274765817355806427083747, DisplayName = "Sin different positive number")]
        [DataRow(0.0, 0, DisplayName = "Sin positive zero double number with no value")]
        [DataRow(10, 0.17364817766693034885171662676931, DisplayName = "Sin positive whole number")]
        [DataRow(5.1, 0.08889429686644151920780187046343, DisplayName = "Sin positive double number with value")]
        [DataRow(10.0, 0.17364817766693034885171662676931, DisplayName = "Sin positive double number with no zero")]
        public void Sin_WhenCalled_ReturnsPositiveNumber(double a, double expectedResult)
        {
            // Act
            var actualResult = _calculator.GetSin(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        [DataRow(-5.0, -0.08715574274765817355806427083747, DisplayName = "Sin negative double number with no value")]
        [DataRow(-10.1, -0.17536672609198711145598126930508, DisplayName = "Sin negative double number with value")]
        [DataRow(-5.1, -0.08889429686644151920780187046343, DisplayName = "Sin different negative double number with value")]
        [DataRow(-5, -0.08889429686644151920780187046343, DisplayName = "Sin negative whole number")]
        [DataRow(-10, -0.17364817766693034885171662676931, DisplayName = "Sin different negative number")]
        [DataRow(-10.0, -0.17364817766693034885171662676931, DisplayName = "Sin negative double number with no value")]
        public void Sin_WhenCalled_ReturnsNegativeNumber(double a, double expectedResult)
        {
            // Act
            var actualResult = _calculator.GetSin(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        [DataTestMethod]
        [Ignore]
        [DataRow(-5.0, DisplayName = "Sin negative double number with no value")]
        [DataRow(-10.1, DisplayName = "Sin negative double number with value")]
        [DataRow(-5.1, DisplayName = "Sin different negative double number with value")]
        [DataRow(-5, DisplayName = "Sin negative whole number")]
        [DataRow(-10, DisplayName = "Sin different negative number")]
        [DataRow(-10.0, DisplayName = "Sin negative double number with no value")]
        public void Sin_UserGetSquareOfNegativeNumber_ThrowsException(double a)
        {
            // Act
            new Calculator().GetSin(a);
        }

        #endregion

        #region Test Cos

        [TestMethod]
        [DataTestMethod]
        [DataRow(0, 1, DisplayName = "Cos positive zero whole number")]
        //[DataRow(5.0, 0.283662185463226, DisplayName = "Cos different positive double number with no value")]
        //[DataRow(10, 0.98480775301220805936674302458952, DisplayName = "Cos positive whole number")]
        //[DataRow(5, 0.283662185463226, DisplayName = "Cos different positive number")]
        //[DataRow(0.0, 1, DisplayName = "Cos positive zero double number with no value")]
        //[Ignore]
        //[DataRow(5.1, 0.99604106541076958023324640524897, DisplayName = "Cos positive double number with value")]
        //[DataRow(10.0, -0.839071529076452, DisplayName = "Cos positive double number with no zero")]
        public void Cos_WhenCalled_ReturnsPositiveNumber(double a, double expectedResult)
        {
            // Act
            var actualResult = _calculator.GetCos(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        [DataRow(-5.0, -0.08715574274765817355806427083747, DisplayName = "Cos negative double number with no value")]
        [DataRow(-10.1, -0.17536672609198711145598126930508, DisplayName = "Cos negative double number with value")]
        [DataRow(-5.1, -0.08889429686644151920780187046343, DisplayName = "Cos different negative double number with value")]
        [DataRow(-5, -0.08889429686644151920780187046343, DisplayName = "Cos negative whole number")]
        [DataRow(-10, -0.17364817766693034885171662676931, DisplayName = "Cos different negative number")]
        [DataRow(-10.0, -0.17364817766693034885171662676931, DisplayName = "Cos negative double number with no value")]
        public void Cos_WhenCalled_ReturnsNegativeNumber(double a, double expectedResult)
        {
            // Act
            var actualResult = _calculator.GetCos(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //[TestMethod]
        //[ExpectedException(typeof(Exception))]
        //[DataTestMethod]
        //[DataRow(-5.0,  DisplayName = "Sin negative double number with no value")]
        //[DataRow(-10.1, DisplayName = "Sin negative double number with value")]
        //[DataRow(-5.1, DisplayName = "Sin different negative double number with value")]
        //[DataRow(-5, DisplayName = "Sin negative whole number")]
        //[DataRow(-10, DisplayName = "Sin different negative number")]
        //[DataRow(-10.0, DisplayName = "Sin negative double number with no value")]
        //public void Sin_UserGetSquareOfNegativeNumber_ThrowsException(double a)
        //{
        //    // Act
        //    new Calculator().GetSin(a);
        //}

        #endregion

        #region Test Tan

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        [DataRow(5.0, 0, DisplayName = "Tan different positive double number with no value")]
        [DataRow(0, 0, DisplayName = "Tan positive zero whole number")]
        [DataRow(5, 0, DisplayName = "Tan different positive number")]
        [DataRow(0.0, 0, DisplayName = "Tan positive zero double number with no value")]
        [DataRow(10, 0, DisplayName = "Tan positive whole number")]
        [DataRow(5.1, 0, DisplayName = "Tan positive double number with value")]
        [DataRow(10.0, 0, DisplayName = "Tan positive double number with no zero")]
        public void Tan_WhenCalled_ReturnsPositiveNumber(double a, double expectedResult)
        {
            // Act
            var actualResult = _calculator.GetTan(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        [DataRow(-5.0, 0, DisplayName = "Tan negative double number with no value")]
        [DataRow(-10.1, 0, DisplayName = "Tan negative double number with value")]
        [DataRow(-5.1, 0, DisplayName = "Tan different negative double number with value")]
        [DataRow(-5, 0, DisplayName = "Tan negative whole number")]
        [DataRow(-10, 0, DisplayName = "Tan different negative number")]
        [DataRow(-10.0, 0, DisplayName = "Tan negative double number with no value")]
        public void Tan_WhenCalled_ReturnsNegativeNumber(double a, double expectedResult)
        {
            // Act
            var actualResult = _calculator.GetTan(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        public void Tan_WhenCalled_ThrowException(double a)
        {
            // Act
            new Calculator().GetTan(a);
        }

        #endregion

        #region Test Log

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        [DataRow(5.0, 0, DisplayName = "Log different positive double number with no value")]
        [DataRow(0, 0, DisplayName = "Log positive zero whole number")]
        [DataRow(5, 0, DisplayName = "Log different positive number")]
        [DataRow(0.0, 0, DisplayName = "Log positive zero double number with no value")]
        [DataRow(10, 0, DisplayName = "Log positive whole number")]
        [DataRow(5.1, 0, DisplayName = "Log positive double number with value")]
        [DataRow(10.0, 0, DisplayName = "Log positive double number with no zero")]
        public void Log_WhenCalled_ReturnsPositiveNumber(double a, double expectedResult)
        {
            // Act
            var actualResult = _calculator.GetLog(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        [DataRow(-5.0, 0, DisplayName = "Log negative double number with no value")]
        [DataRow(-10.1, 0, DisplayName = "Log negative double number with value")]
        [DataRow(-5.1, 0, DisplayName = "Log different negative double number with value")]
        [DataRow(-5, 0, DisplayName = "Log negative whole number")]
        [DataRow(-10, 0, DisplayName = "Log different negative number")]
        [DataRow(-10.0, 0, DisplayName = "Log negative double number with no value")]
        public void Log_WhenCalled_ReturnsNegativeNumber(double a, double expectedResult)
        {
            // Act
            var actualResult = _calculator.GetLog(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        public void Log_WhenCalled_ThrowException(double a)
        {
            // Act
            new Calculator().GetLog(a);
        }

        #endregion

        #region Test Exp

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        [DataRow(5.0, 0, DisplayName = "Exp different positive double number with no value")]
        [DataRow(0, 0, DisplayName = "Exp positive zero whole number")]
        [DataRow(5, 0, DisplayName = "Exp different positive number")]
        [DataRow(0.0, 0, DisplayName = "Exp positive zero double number with no value")]
        [DataRow(10, 0, DisplayName = "Exp positive whole number")]
        [DataRow(5.1, 0, DisplayName = "Exp positive double number with value")]
        [DataRow(10.0, 0, DisplayName = "Exp postive double number with no zero")]
        public void Exp_WhenCalled_ReturnsPositiveNumber(double number, decimal expectedResult)
        {
            //Assert.That(Math.Round(result, sigDigits), Assert.AreEqual(Ex));
            // Act
            var actualResult = _calculator.GetExp(number);
            //var compare = actualResult == expectedResult;

            // Assert
            //Assert.AreSame(expectedResult, actualResult);
            //Assert.IsTrue(expectedResult);
            //Assert.IsFalse(compare);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        [DataRow(-5.0, 0, DisplayName = "Exp negative double number with no value")]
        [DataRow(-10.1, 0, DisplayName = "Exp negative double number with value")]
        [DataRow(-5.1, 0, DisplayName = "Exp different negative double number with value")]
        [DataRow(-5, 0, DisplayName = "Exp negative whole number")]
        [DataRow(-10, 0, DisplayName = "Exp different negative number")]
        [DataRow(-10.0, 0, DisplayName = "Exp negative double number with no value")]
        public void Exp_WhenCalled_ReturnsNegativeNumber(double a, double expectedResult)
        {
            // Act
            var actualResult = _calculator.GetExp(a);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DataTestMethod]
        [Ignore]
        public void Exp_WhenCalled_ThrowException(double a)
        {
            // Act
            new Calculator().GetExp(a);
        }

        #endregion

        #region Test User input

        [TestMethod]
        [Ignore]
        public void Main_UserEnterFirstNumber_GetDoubleDataType()
        {

            // Act
           // var actualResult = (a);

            //Assert.IsInstanceOfType(double, GetType());
        }



        #endregion

    }
}