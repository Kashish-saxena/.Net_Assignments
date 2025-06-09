class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine(
            "Choose an option to start running a program:\n1. Factorial\n2. Calculator\n3. Menu Driven Program\n4. Exit"
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
            case "3":
                EmployeeManagement employee = new EmployeeManagement();
                employee.getUserInput();
                break;
            case "4":
                break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }
    }
}