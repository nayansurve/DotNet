using HR.Domain.Entities;
namespace HR.Application.Interface;




public interface IEmployeeService
{
    double GetSalary(Employee employee);
    void PerformDuties(Employee employee);

    void AddEmployee (Employee employee);

    List<Employee> GetEmployees();
    
   
}