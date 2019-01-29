using System;

namespace CalculatorFunctions
{
    public class Calculator
    {
        #region Interface
        public void GetInput()
        {
            Calculator calculate = new Calculator();
            bool userOption = false;
            double firstNumber, secondNumber, answer;
            //string firstNumber, secondNumber;
            string function;

            Console.WriteLine("Calculator Console App");

            while (!userOption)
            {
                #region Userinput
                Console.Write("\nEnter first number: ");
                firstNumber = double.Parse(Console.ReadLine());

                if(firstNumber == null)
                    throw new ArgumentNullException(nameof(firstNumber), "Number must not be null");

                Console.Write("Enter second number: ");
                secondNumber = double.Parse(Console.ReadLine());

                if (secondNumber == null)
                    throw new ArgumentNullException(nameof(firstNumber), "Number must not be null");

                Console.Write("\n(+, -, *, /, sq = SquareRoot, s = Sin, c = Cos, t = Tan, l = Log, e = Exp)\nSelect an Opertator or \"q\": ");
                function = Console.ReadLine();
                #endregion

                #region Output switch if & switch 

                if (string.IsNullOrWhiteSpace(function))
                    throw new Exception("\aNot a number");

                else switch (function)
                    {
                        case "+":
                            answer = calculate.Add(firstNumber, secondNumber);
                            Console.Clear();
                            Console.WriteLine($"Answer: {firstNumber} {function} {secondNumber} = {answer}");
                            userOption = false;
                            continue;
                        case "-":
                            answer = calculate.Substract(firstNumber, secondNumber);
                            Console.Clear();
                            Console.WriteLine($"Answer: {firstNumber} {function} {secondNumber} = {answer}");
                            continue;
                        case "*":
                            answer = calculate.Multiply(firstNumber, secondNumber);
                            Console.Clear();
                            Console.WriteLine($"Answer: {firstNumber} {function} {secondNumber} = {answer}");
                            continue;
                        case "/":
                            answer = calculate.Multiply(firstNumber, secondNumber);
                            Console.Clear();
                            Console.WriteLine($"Answer: {firstNumber} {function} {secondNumber} = {answer}");
                            continue;
                        case "sq":
                            answer = calculate.GetSquareRoot(firstNumber);
                            Console.Clear();
                            Console.WriteLine($"Answer: Rounded Square Root of {firstNumber} = {answer}");
                            continue;
                        case "s":
                            answer = calculate.GetSin(firstNumber);
                            Console.Clear();
                            Console.WriteLine($"Answer: Rounded Sin of {firstNumber} = {answer}");
                            continue;
                        case "c":
                            answer = calculate.GetCos(firstNumber);
                            Console.Clear();
                            Console.WriteLine($"Answer: Rounded Cos of {firstNumber} = {answer}");
                            continue;
                        case "t":
                            answer = calculate.GetTan(firstNumber);
                            Console.Clear();
                            Console.WriteLine($"Answer: Rounded Tan of {firstNumber} = {answer}");
                            continue;
                        case "l":
                            answer = calculate.GetLog(firstNumber);
                            Console.Clear();
                            Console.WriteLine($"Answer: Rounded Log of {firstNumber} = {answer}");
                            continue;
                        case "e":
                            answer = calculate.GetExp(firstNumber);
                            Console.Clear();
                            Console.WriteLine($"Answer: Rounded Exp of {firstNumber} = {answer}");
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

        #endregion

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
            return Math.Round(number1 * number2);
        }

        public double GetSquareRoot(double number)
        {
            return (number < -0.0 || number < 0) ? throw new Exception("\aNot a number") : Math.Round(Math.Sqrt(number));
        }

        public double GetSin(double number)
        {
            return Math.Round(Math.Sin(number));
        }

        public double GetCos(double number)
        {
            return Math.Round(Math.Cos(number));
        }

        public double GetTan(double number)
        {
            return Math.Round(Math.Tan(number));
        }

        public double GetLog(double number)
        {
           return Math.Round(Math.Log(number));
        }

        public double GetExp(double number)
        {
            return Math.Round(Math.Exp(number));
        }
        #endregion
    }
}