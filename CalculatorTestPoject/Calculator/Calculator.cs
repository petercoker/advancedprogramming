using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            {
                throw new ArgumentNullException(nameof(number2));
            }

            else
            {
                Console.WriteLine(number1 / number2);
            }
        
        }

        public double Mutliply(double number1, double number2)
        {
            return number1 * number2;
        }

        public double Modulo(double number1, double number2)
        {
            return number1 % number2;
        }
    }
}
