using HR.Domain.Entities;

namespace HR.Application.Services;

public class PayrollService
{
    public double CalculateSalary(Employee employee)
    {
        return employee.CalculateSalary();
    }
}