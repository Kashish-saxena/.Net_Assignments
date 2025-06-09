// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Diagnostics;

class Calculator
{
    public void calculate()
    {
        bool running = true;
        try
        {
            do
            {
                Console.WriteLine("Enter 1st number: ");
                string num1 = Console.ReadLine() ?? "";
                Console.WriteLine("Enter 2nd number: ");
                string num2 = Console.ReadLine() ?? "";
                double result = Operation(double.Parse(num1), double.Parse(num2));
                Console.WriteLine("Result is: " + result);
                Console.WriteLine("Do you want to continue? Y/N");
                string userChoice = Console.ReadLine() ?? "";
                userChoice = userChoice.ToLower();
                if (userChoice == "y" || userChoice == "yes")
                {
                    running = true;
                }
                else
                {
                    running = false;
                }
            } while (running);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
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
}

