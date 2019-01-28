using System;
using System.Data;
using System.Runtime.InteropServices;

namespace CalculatorFunctions
{
    public class Calculator
    {
        #region Functions

        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Substract(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Divide(double number1, double number2)
        {
            return (number2 == 0) ? throw new DivideByZeroException("\aCan not divide by 0") : number1 / number2;
        }

        public double Multiply(double number1, double number2)
        {
            double sum = number1 * number2;
            return sum;
        }

        public double GetSquareRoot(double number)
        {
            return (number < -0.0 || number < 0) ? throw new Exception("\aNot a number") : Math.Sqrt(number);
        }

        public double GetSin(double number)
        {
            double sum = Math.Sin(number);
            return sum;
        }

        public double GetCos(double number)
        {
            double sum = Math.Cos(number);
            return sum;
        }

        public double GetTan(double number)
        {
            double sum = Math.Cos(number);
            return sum;
        }

        public double GetLog(double number)
        {
            double sum = Math.Log(number);
            return sum;
        }

        public double GetExp(double number)
        {
            return Math.Round(Math.Exp(number));
            //return (Math.Abs(Math.Exp(number) <= 0.00001) ? true : false;
        }


        #endregion

        #region Input

        public void GetInput(string value)
        {
           
        }

        #endregion
    }
}