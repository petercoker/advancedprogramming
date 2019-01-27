using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class CalculatorMenu
    {
        #region Menu

        public void GetCalculatorMenu()
        {
            Console.WriteLine("1: Add two numbers");
            Console.WriteLine("2: Substract two numbers");
            Console.WriteLine("3: Divide two numbers");
            Console.WriteLine("4: Multiply two numbers");
            Console.WriteLine("5: Modulo two numbers");
            Console.WriteLine("6: Get Square of a number");
            Console.WriteLine("7: Get Sin of a number");
            Console.WriteLine("8: Get Cos of a number");
            Console.WriteLine("9: Get Tan of a number");
            Console.WriteLine("10: Get Log of a number");
        }
        #endregion

        #region ValidateFirstNumber

        public void InputFirstNumber()
        {
            Console.Write("Enter first numbers to add: ");
            string firstNumber = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(firstNumber))
            {
                Console.WriteLine("\n\aInvalid Input, please enter a number");
              
            }

            else
            {
                
            }
        }
        

        #endregion
    }
}
