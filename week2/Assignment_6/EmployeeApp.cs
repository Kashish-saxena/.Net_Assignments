public class EmployeeApp
{
    private List<EmployeeModel> employees = new List<EmployeeModel>();

    public void GetUserInput()
    {
        int choice = 0;

        do
        {
            Console.WriteLine("\n>>> EMPLOYEE MANAGEMENT SYSTEM <<<");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. Display All Employees");
            Console.WriteLine("3. Clear All Employees");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            try
            {
                choice = int.Parse(Console.ReadLine() ?? "0");
            }
            catch
            {
                Console.WriteLine("Please enter a valid choice.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddEmployee();
                    break;
                case 2:
                    DisplayEmployees();
                    break;
                case 3:
                    ClearAllEmployees();
                    break;
                case 4:
                    break;
                default:
                    Console.WriteLine("Invalid input. Please choose 1 to 4.");
                    break;
            }

        } while (choice != 4);
    }

    private void AddEmployee()
    {
        int id = GetValidInt("Enter ID: ");
        string name = GetValidString("Enter Name: ");
        string dept = GetValidString("Enter Department: ");
        double salary = GetValidDouble("Enter Salary: ");

        employees.Add(new EmployeeModel(id, name, dept, salary));
        Console.WriteLine("Employee added successfully.");
    }

    private void DisplayEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees found.");
            return;
        }

        Console.WriteLine("\n--- Employee List ---");
        foreach (var emp in employees)
        {
            emp.Display();
        }
    }

    private void ClearAllEmployees()
    {
        if (employees.Count == 0)
        {
            Console.WriteLine("No employees to clear.");
            return;
        }

        Console.Write("Are you sure you want to delete all employees? (yes/no): ");
        string confirmation = Console.ReadLine()?.Trim().ToLower() ?? "n";

        if (confirmation == "yes" || confirmation == "y")
        {
            employees.Clear();
            Console.WriteLine("All employee data have been cleared.");
        }
        else
        {
            Console.WriteLine("Operation cancelled.");
        }
    }

    private string GetValidString(string message)
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

    private int GetValidInt(string message)
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
                Console.WriteLine("Invalid number. Please enter a valid integer.");
            }
        }
    }

    private double GetValidDouble(string message)
    {
        while (true)
        {
            Console.Write(message);
            string input = Console.ReadLine() ?? "0.0";

            try
            {
                return double.Parse(input);
            }
            catch
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
            }
        }
    }
}
