using System;

namespace CalculatorFunctions
{
    public class Calculator
    {
        #region Input
        public static string Choice()
        {
            string choice;
            do
            {
                Console.Write(
                    "\n(+, -, *, /, %, sq = SquareRoot, s = Sin, c = Cos, t = Tan, l = Log)\nSelect an Opertator or \"q\": ");
                choice = Console.ReadLine();

            } while (string.IsNullOrWhiteSpace(choice));
            return choice;
        }

        public double GetSecondNumber()
        {
            double secondNumber;
            do
            {
               Console.Write("Enter second number: ");
            } while (!double.TryParse(Console.ReadLine(), out secondNumber));
            return secondNumber;
        }

        public double GetFirstNumber()
        {
            double firstNumber;
            do
            {
               Console.Write("\nEnter first number: ");
            } while(!double.TryParse(Console.ReadLine(), out firstNumber));
            return firstNumber;
        }
        #endregion

        #region Functions

        public double Add(double number1, double number2)
        {
            return Math.Round(number1 + number2);
        }

        public double Substract(double number1, double number2)
        {
            return Math.Round(number1 - number2);
        }

        public double Divide(double number1, double number2)
        {
            return (number2 == 0) ? throw new DivideByZeroException("\aCan not divide by 0") : Math.Round(number1 / number2);
        }

        
        public double Multiply(double number1, double number2)
        {
            return Math.Round(number1 * number2);
        }

        public double Modulo(double number1, double number2)
        {
            return (number2 == 0 || number2 == 0.0) ? throw new DivideByZeroException("\aCan not divide by 0") : Math.Round(number1 % number2);
        }

        public double GetSquareRoot(double number1)
        {
            return (number1 < -0.0 || number1 < 0) ? throw new Exception("\aNot a number") : Math.Round(Math.Sqrt(number1));
        }

        public double GetSin(double number1)
        {
            return Math.Round(Math.Sin(number1));
        }

        public double GetCos(double number1)
        {
            return Math.Round(Math.Cos(number1));
        }

        public double GetTan(double number1)
        {
            return Math.Round(Math.Tan(number1));
        }

        public double GetLog(double number1)
        {
            return (number1 <= 0 || number1 <= 0.0) ? throw new Exception("\aInvalid input") : Math.Round(Math.Log(number1));
        }

        #endregion
    }
}