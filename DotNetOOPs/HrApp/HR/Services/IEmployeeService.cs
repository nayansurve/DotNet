namespace HR.Services;
using HrApp;

public interface IEmployeeService
{
    double GetSalary(Employee employee);
    void PerformDuties(Employee employee);

    void AddEmployee (Employee employee);

    List<Employee> GetEmployees();
    
   
}