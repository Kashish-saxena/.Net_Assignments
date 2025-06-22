class IComparerQuery
{
    public void ApplyLinqQueriesOnEmployee()
    {
        GetEmployeeModelData employeeData = new GetEmployeeModelData();
        List<EmployeeModel> employees = employeeData.EmployeeModels;

        employees.Sort(new SalaryDescendingComparer());

        foreach (var emp in employees)
        {
            Console.WriteLine($"Employees Filtered by salary using IComparer ==> {emp.Name} - {emp.Department} - {emp.Salary}");
        }
    }
}