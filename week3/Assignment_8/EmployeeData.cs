class GetEmployeeModelData
{
    public List<EmployeeModel> EmployeeModels { get; set; }
    public GetEmployeeModelData()
    {

        EmployeeModels = new List<EmployeeModel>
    {
        new EmployeeModel(id: 1, name: "Kashish", department: "HR", salary: 60000),
        new EmployeeModel(id: 2, name: "Tester1", department: "IT", salary: 75000),
        new EmployeeModel(id: 0, name: "", department: "", salary: 0),
        new EmployeeModel(id: 3, name: "Tester2", department: "IT", salary: 65000),
        new EmployeeModel(id: 4, name: "Tester3", department: "Finance", salary: 70000)
    };
    }
}
