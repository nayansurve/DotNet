using HR.Application.Interfaces;
using HR.Domain.Entities;

namespace HR.Application.Services;

public class EmployeeService
{
    private readonly IEmployeeRepository _employeeRepository;

    public EmployeeService(IEmployeeRepository employeeRepository)
    {
        _employeeRepository=employeeRepository;
    }

    public void Hire(Employee employee)
    {
        _employeeRepository.Add(employee);
    }

   public List<Employee> GetEmployees()
    {
        return _employeeRepository.GetAll();
    }
}
