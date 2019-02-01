using System;
using CalculatorFunctions;

namespace CACalulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculate = new Calculator();
            bool userOption = false;
            double firstNumber;
            double secondNumber;
            string choice;

            while (!userOption)
            {
                Console.WriteLine("\nCalculator Console App");
                firstNumber = calculate.GetFirstNumber();
                secondNumber = calculate.GetSecondNumber();
                choice = Calculator.Choice();

                switch (choice)
                {
                    case "+":
                        Console.Clear();
                        Console.WriteLine(
                            $"Answer: {firstNumber} {choice} {secondNumber} = {calculate.Add(firstNumber, secondNumber)}");
                        continue;
                    case "-":
                        Console.WriteLine(
                            $"Answer: {firstNumber} {choice} {secondNumber} = {calculate.Substract(firstNumber, secondNumber)}");
                        continue;
                    case "*":
                        Console.WriteLine(
                            $"Answer: {firstNumber} {choice} {secondNumber} = {calculate.Multiply(firstNumber, secondNumber)}");
                        continue;
                    case "/":
                        Console.Clear();
                        Console.WriteLine(
                            $"Answer: {firstNumber} {choice} {secondNumber} = {calculate.Substract(firstNumber, secondNumber)}");
                        continue;
                    case "%":
                        Console.Clear();
                        Console.WriteLine(
                            $"Answer: {firstNumber} {choice} {secondNumber} = {calculate.Modulo(firstNumber, secondNumber)}");
                        continue;
                    case "sq":
                        Console.Clear();
                        Console.WriteLine(
                            $"Answer: {firstNumber} {choice} {secondNumber} = {calculate.GetSquareRoot(firstNumber)}");
                        continue;
                    case "s":
                        Console.Clear();
                        Console.WriteLine($"Answer: Rounded Sin of {firstNumber} = {calculate.GetSin(firstNumber)}");
                        continue;
                    case "c":
                        Console.Clear();
                        Console.WriteLine($"Answer: Rounded Cos of {firstNumber} = {calculate.GetCos(firstNumber)}");
                        continue;
                    case "t":
                        Console.Clear();
                        Console.WriteLine($"Answer: Rounded Tan of {firstNumber} = {calculate.GetTan(firstNumber)}");
                        continue;
                    case "l":
                        Console.Clear();
                        Console.WriteLine($"Answer: Rounded Log of {firstNumber} = {calculate.GetLog(firstNumber)}");
                        continue;
                    case "q":
                        userOption = true;
                        break;
                    default:
                        Console.WriteLine("\aWrong opertator, please select an operator");
                        continue;
                }
            }
        }
    }
}
