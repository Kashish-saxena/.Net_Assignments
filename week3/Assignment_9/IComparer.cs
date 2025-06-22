public class SalaryDescendingComparer : IComparer<EmployeeModel>
{
    public int Compare(EmployeeModel? x, EmployeeModel? y)
    {
        if (x == null || y == null)
            return 0;
        return y.Salary.CompareTo(x.Salary);
    }
}