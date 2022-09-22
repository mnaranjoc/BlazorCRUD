namespace BlazorApp1.Data
{
    public class EmployeeService : IEmployeeService
    {
        public List<Employee> Employees = new()
        {
            new() { Id = Guid.NewGuid(), Name = "User 1" },
            new() { Id = Guid.NewGuid(), Name = "User 2" }
        };

        public List<Employee> GetEmployees()
            => Employees;

        public Employee GetEmployee(Guid id)
            => Employees.FirstOrDefault(e => e.Id == id);
    }
}
