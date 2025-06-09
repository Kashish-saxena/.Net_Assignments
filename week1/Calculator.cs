// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Diagnostics;

class Calculator
{
    public void calculate()
    {
        bool running = true;
        do
        {
            double num1 = GetValidDouble("Enter 1st number: ");
            double num2 = GetValidDouble("Enter 2nd number: ");

            try
            {
                double result = Operation(num1, num2);
                Console.WriteLine("Result is: " + result);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error during operation: " + e.Message);
            }

            Console.Write("Do you want to continue? Y/N: ");
            string userChoice = (Console.ReadLine() ?? "").Trim().ToLower();

            running = userChoice == "y" || userChoice == "yes";

        } while (running);
    }

    private static double Operation(double num1, double num2)
    {
        Console.WriteLine("Enter the operation you want to perform:\n1. Add\n2. Subtract\n3. Multiply\n4. Divide");
        string operation = Console.ReadLine() ?? "";
        double result = 0;
        switch (operation)
        {
            case "1":
                result = num1 + num2;
                break;
            case "2":
                result = num1 - num2;
                break;
            case "3":
                result = num1 * num2;
                break;
            case "4":
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Divisor cannot be zero");
                }
                break;
            default:
                Console.WriteLine("Invalid Input !!! Please try again");
                break;
        }
        return result;
    }

    static double GetValidDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? "";

            try
            {
                double value = Double.Parse(input);
                return value;
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}

