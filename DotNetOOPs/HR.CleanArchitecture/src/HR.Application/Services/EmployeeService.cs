//namespace HR.Services;
using HR.Domain.Entities;
using HR.Application.Interface;


namespace HR.Application.Services;

public class EmployeeService : IEmployeeService


{
    private readonly IEmployeeRepository _employeeRepository;
    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository=employeeRepository;
    }
    public double GetSalary(Employee employee)
    {
        employee.DoWork();
        return employee.ComputePay();
    }

    public void PerformDuties(Employee employee)
    {
        employee.DoWork();
        Console.WriteLine("Duties Completed");
    }
    public void AddEmployee(Employee employee)
    {
        _employeeRepository.Add(employee);
    }
    public List<Employee> GetEmployees()
    {
        return _employeeRepository.GetByAll();
    }
    
}