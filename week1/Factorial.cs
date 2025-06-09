class Factorial
{
    public void getFactorial()
    {
        try
        {
            Console.Write("Enter a number to find it's factorial: ");
            string input = Console.ReadLine() ?? "";
            int num = int.Parse(input);
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
}
