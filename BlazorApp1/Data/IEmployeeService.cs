namespace BlazorApp1.Data
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployees();

        public Employee GetEmployee(Guid id);

        public void UpdateEmployee(Employee employee);

        public void AddEmployee(Employee employee);
    }
}
