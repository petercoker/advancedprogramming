using System;

namespace CalculatorFunctions
{
    public class Calculator
    {
        public double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public double Substact(double number1, double number2)
        {
            return number1 - number2;
        }

        public double Divide(double number1, double number2)
        {
            return (number2 == 0) ? throw new DivideByZeroException("\aCan not divide by 0") : number1 / number2;
        }
        
        public double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Modulo(double number1, double number2)
        {
            return number1 % number2;
        }

        public double GetSquareRoot(double number)
        {
            return Math.Sqrt(number);
        }

        public double GetCos(double number)
        {
            return Math.Cos(number);
        }

        public double GetTan(double number)
        {
            return Math.Tan(number);
        }

        public double GetLog(double number)
        {
            return Math.Log(number);
        }

        public double GetSin(double number)
        {
            return Math.Sin(number);
        }
    }
}