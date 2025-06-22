class Utils
{
    public static string GetValidString(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine() ?? "";

            if (!string.IsNullOrWhiteSpace(input))
                return input;

            Console.WriteLine("Input cannot be empty. Please try again.");
        }
    }

    public static int GetValidInt(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine() ?? "0";

            try
            {
                return int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
    public static long GetValidLong(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine()?.Trim() ?? "";

            if (input.Length == 10 && input.All(char.IsDigit))
            {
                try
                {
                    return long.Parse(input);
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter a valid 10-digit number.");
                }
            }
            else
            {
                Console.WriteLine("Phone number must be exactly 10 digits and numeric.");
            }
        }
    }

}