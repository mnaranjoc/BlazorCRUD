namespace BlazorApp1.Data
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployees();

        public Employee GetEmployee(Guid id);
    }
}
