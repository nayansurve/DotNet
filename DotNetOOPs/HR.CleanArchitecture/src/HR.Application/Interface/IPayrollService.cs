using HR.Domain.Entities;
namespace HR.Application.Interface;



public interface IPayrollService
{
    void GeneratePayslip(Employee employee);
}