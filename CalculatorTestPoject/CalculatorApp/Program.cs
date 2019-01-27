using System;
using CalculatorFunctions;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            CalculatorMenu calculatorMenu = new CalculatorMenu();
            double number1, number2;
            bool keepGoing = true, userOption = true;
            string inputOption;

            while (keepGoing)
            {
                keepGoing = false;

                while (userOption)
                {
                    calculatorMenu.GetCalculatorMenu();

                    Console.Write("\nPlease enter a number listed by the menu above, with no spaces in between the number: ");
                    inputOption = Console.ReadLine();

                    if (String.IsNullOrWhiteSpace(inputOption))
                    {
                        Console.WriteLine("\n\aInvalid Input, please enter a number");
                        continue;
                    }

                    else if (int.TryParse(inputOption, out int option))
                    {
                        switch (option)
                        {
                            case 1:
                                Console.Write("Enter first numbers to add: ");
                                string firstNumber = Console.ReadLine();
                                
                                if (String.IsNullOrWhiteSpace(firstNumber))
                                {
                                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                                    return;
                                }

                                Console.Write("Enter first numbers to add: ");
                                string secondNumber = Console.ReadLine();

                                if (String.IsNullOrWhiteSpace(secondNumber))
                                {
                                    Console.WriteLine("\n\aInvalid Input, please enter a number");
                                    return;
                                }

                                number1 = double.Parse(firstNumber);
                                number2 = double.Parse(firstNumber);
                                Console.WriteLine($"{number1} + {number2} = {calculator.Add(number1, number2)}");
                                
                                break;

                            case 2:
                                //calculator.Substact();
                                break;

                            //case 3:
                            //    ShowAllPostgradStudents();
                            //    break;

                            //case 4:
                            //    ShowAllUndergradStudents();
                            //    break;

                            //case 5:
                            //    ShowAllCurrentStudents();
                            //    break;

                            //case 6:
                            //    ShowAllPostgradCurrentStudents();
                            //    break;

                            //case 7:
                            //    ShowAllUndergradCurrentStudents();
                            //    break;

                            //case 8:
                            //    ShowAllNotCurrentStudents();
                            //    break;

                            //case 9:
                            //    ShowAllPostgradNotCurrentStudents();
                            //    break;

                            //case 10:
                            //    ShowAllUndergradNotCurrentStudents();
                            //    break;

                            case 11:
                                Console.Clear();
                                Console.WriteLine("Thank you for using the Student management system");
                                userOption = false;
                                break;

                            default:
                                Console.WriteLine("\n\aThat is not an option");
                                continue;
                        }
                    }

                    else
                    {
                        Console.WriteLine("\n\aInvalid Input ");
                        continue;
                    }
                }

            }

        }
    }
}
