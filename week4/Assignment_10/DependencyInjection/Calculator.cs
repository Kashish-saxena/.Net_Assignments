
// Create a .NET Core Console App that uses DI to perform a calculation service.
namespace Assignment_10;

public interface ICalculator
{
    void Calculate();
    double Add(double a, double b);
    double Subtract(double a, double b);
    double Multiply(double a, double b);
    double Divide(double a, double b);
}

public class Calculator : ICalculator
{
    public void Calculate()
    {
        bool running = true;
        do
        {
            double num1 = GetValidDouble("Enter 1st number: ");
            double num2 = GetValidDouble("Enter 2nd number: ");

            try
            {
                double result = PerformOperation(num1, num2);
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

    private double PerformOperation(double num1, double num2)
    {
        Console.WriteLine("Choose an operation:\n1. Add\n2. Subtract\n3. Multiply\n4. Divide");
        string choice = Console.ReadLine() ?? "";
        switch (choice)
        {
            case "1":
                return Add(num1, num2);
            case "2": return Subtract(num1, num2);
            case "3": return Multiply(num1, num2);
            case "4": return Divide(num1, num2);
            default: throw new InvalidOperationException("Invalid operation selected.");
        }
    }

    public double Add(double a, double b) => a + b;

    public double Subtract(double a, double b) => a - b;

    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }

    private static double GetValidDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? "";

            if (double.TryParse(input, out double value))
            {
                return value;
            }
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}


