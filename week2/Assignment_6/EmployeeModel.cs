public class EmployeeModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public EmployeeModel(int id, string name, string department, double salary)
    {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"ID: {Id}, Name: {Name}, Dept: {Department}, Salary: {Salary}");
    }
}

