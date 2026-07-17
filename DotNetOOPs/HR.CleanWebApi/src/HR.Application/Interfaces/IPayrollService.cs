using HR.Domain.Entities;

namespace HR.Application.Interfaces;

public interface IPayrollService
{
    public void CalculateSalary(Employee employee);
}