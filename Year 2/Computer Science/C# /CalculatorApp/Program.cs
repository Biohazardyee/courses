using System;
using System.Collections.Generic;
using System.IO;


namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string historyFilePath = "history.txt";
            List<string> history = new List<string>();

            if (File.Exists(historyFilePath))
            {
                string[] savedHistory = File.ReadAllLines(historyFilePath);
                history.AddRange(savedHistory);
            }


            while (true)
            {
                Console.WriteLine("Welcome To This CalculatorApp");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Choose An Option");
                Console.WriteLine();
                Console.WriteLine("1. Make a new calculation");
                Console.WriteLine("2. See history");
                Console.WriteLine("3. Exit");

                int choice;
                string? input = Console.ReadLine();
                if (input == null || !int.TryParse(input, out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.Clear();
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter your number: ");
                        string? inputNumber1 = Console.ReadLine();
                        if (inputNumber1 == null || !double.TryParse(inputNumber1, out _))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            Console.Clear();
                            continue;
                        }

                        Console.WriteLine("Enter your operator (+, -, *, /): ");
                        string? inputOperator = Console.ReadLine();
                        if (inputOperator != "+" && inputOperator != "-" && inputOperator != "*" && inputOperator != "/")
                        {
                            Console.WriteLine("Enter a valid operator");
                            Console.Clear();
                            continue;
                        }

                        Console.WriteLine("Enter your second number: ");
                        string? inputNumber2 = Console.ReadLine();
                        if (inputNumber2 == null || !double.TryParse(inputNumber2, out _))
                        {
                            Console.WriteLine("Invalid input. Please enter a number.");
                            Console.Clear();
                            continue;
                        }

                        double number1 = double.Parse(inputNumber1);
                        double number2 = double.Parse(inputNumber2);
                        double result = 0;
                        bool validOperation = true;

                        switch (inputOperator)
                        {
                            case "+":
                                result = number1 + number2;
                                break;

                            case "-":
                                result = number1 - number2;
                                break;

                            case "*":
                                result = number1 * number2;
                                break;

                            case "/":
                                if (number2 == 0)
                                {
                                    Console.WriteLine("Error: Division by zero.");
                                    validOperation = false;
                                }
                                else
                                {
                                    result = number1 / number2;
                                }
                                break;
                        }

                        if (validOperation)
                        {
                            string operationString = $"{number1} {inputOperator} {number2} = {result}";
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("Result: " + operationString);
                            history.Add(operationString);

                            File.AppendAllText(historyFilePath, operationString + Environment.NewLine);
                        }
                        break;

                    case 2:
                        if (history.Count == 0)
                        {
                            Console.WriteLine("You've got no operation yet");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("History of operations:");
                            foreach (var entry in history)
                            {
                                Console.WriteLine(entry);
                            }
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Goodbye");
                        return;
                }
            }
        }
    }
}