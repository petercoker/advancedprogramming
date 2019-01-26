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
            return number1 / number2;
        }

        public void DivideByZero(double number1, double number2)
        {
            if (number2 == 0)
                throw new ArgumentNullException(nameof(number2));

            Console.WriteLine(number1 / number2);
        }

        public double Multiply(double number1, double number2)
        {
            //decimal sum = Convert.ToDecimal(number1 * number2);
            //return sum;
            return number1 * number2;
        }

        public double Modulo(double number1, double number2)
        {
            return number1 % number2;
        }
    }
}