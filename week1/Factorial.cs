class Factorial
{
    public void getFactorial()
    {
        try
        {
            int num = GetValidInt("Enter a number to find it's factorial: ");
            double fact = factorial(num);
            Console.WriteLine("Factorial of " + num + " is: " + fact);
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception occured:" + e.Message);
        }
    }

    private static double factorial(double num)
    {
        if (num == 1 || num == 0)
        {
            return 1;
        }
        return (double)(num * factorial(num - 1));
    }

    static int GetValidInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? "";


            try
            {
                int value = int.Parse(input);
                if (value < 0)
                {
                    Console.WriteLine("Please enter a non-negative integer.");
                    continue;
                }
                return value;
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}
