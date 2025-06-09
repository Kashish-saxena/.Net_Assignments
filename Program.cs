class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(
            "Choose an option to start running a program:\n1. Factorial\n2. Calculator"
        );
        string userInput = Console.ReadLine() ?? "";
        switch (userInput)
        {
            case "1":
                Factorial factorial = new Factorial();
                factorial.getFactorial();
                break;
            case "2":
                Calculator calculator = new Calculator();
                calculator.calculate();
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}