class LinqQueriesOnEmployee
{
    public void ApplyLinqQueriesOnEmployee()
    {
        GetEmployeeModelData employeeData = new GetEmployeeModelData();
        List<EmployeeModel> employees = employeeData.EmployeeModels;

        var result = employees
    .Where(emp => emp.Department == "IT")
    .OrderByDescending(emp => emp.Salary);

        foreach (var emp in result)
        {
            Console.WriteLine($"Employees Filtered by Department and ordered by salary ==> {emp.Name} - {emp.Department} - {emp.Salary}");
        }
    }
}