using CalculatorFunctions;
using System;

namespace testing
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calculate = new Calculator();
            bool userOption = false;
            double number1, number2, answer;
            string firstNumber, secondNumber;
            string opertator;

            while (!userOption)
            {
                #region Userinput
                Console.Write("\nEnter first number: ");
                firstNumber = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(firstNumber))
                    throw new Exception("\aNot a number");
                else
                    double.TryParse(firstNumber, out number1);

                Console.Write("Enter second number: ");
                secondNumber = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(secondNumber))
                    throw new Exception("\aNot a number");
                else
                    double.TryParse(secondNumber, out number2);

                Console.Write("\n(+, -, *, /, sq = SquareRoot, s = Sin, c = Cos, t = Tan, l = Log, e = Exp)\nSelect an Opertator or \"q\": ");
                opertator = Console.ReadLine();
                #endregion

                #region Output switch if & switch 

                if (string.IsNullOrWhiteSpace(opertator))
                    throw new Exception("\aNot a number");

                else switch (opertator)
                {
                    case "+":
                        answer = Calculate.Add(number1, number2);
                        Console.Clear();
                        Console.WriteLine($"Answer: {number1} {opertator} {number2} = {answer}");
                        userOption = false;
                        continue;
                    case "-":
                        answer = Calculate.Substract(number1, number2);
                        Console.Clear();
                        Console.WriteLine($"Answer: {number1} {opertator} {number2} = {answer}");
                        continue;
                    case "*":
                        answer = Calculate.Multiply(number1, number2);
                        Console.Clear();
                        Console.WriteLine($"Answer: {number1} {opertator} {number2} = {answer}");
                        continue;
                    case "/":
                        answer = Calculate.Multiply(number1, number2);
                        Console.Clear();
                        Console.WriteLine($"Answer: {number1} {opertator} {number2} = {answer}");
                        continue;
                    case "sq":
                        answer = Calculate.GetSquareRoot(number1);
                        Console.Clear();
                        Console.WriteLine($"Answer: {number1} {opertator} {number2} = {answer}");
                        continue;
                    case "s":
                        answer = Calculate.GetSin(number1);
                        Console.Clear();
                        Console.WriteLine($"Answer: {number1} {opertator} {number2} = {answer}");
                        continue;
                    case "c":
                        answer = Calculate.GetCos(number1);
                        Console.Clear();
                        Console.WriteLine($"Answer: {number1} {opertator} {number2} = {answer}");
                        continue;
                    case "t":
                        answer = Calculate.GetTan(number1);
                        Console.Clear();
                        Console.WriteLine($"Answer: {number1} {opertator} {number2} = {answer}");
                        continue;
                    case "l":
                        answer = Calculate.GetLog(number1);
                        Console.Clear();
                        Console.WriteLine($"Answer: {number1} {opertator} {number2} = {answer}");
                        continue;
                    case "e":
                        answer = Calculate.GetExp(number1);
                        Console.Clear();
                        Console.WriteLine($"Answer: {number1} {opertator} {number2} = {answer}");
                        continue;
                    case "q":
                        userOption = true;
                        break;
                    default:
                        Console.WriteLine("Wrong opertator, please select an operator");
                        continue;
                }

                #endregion
            }
        }
    }
}
