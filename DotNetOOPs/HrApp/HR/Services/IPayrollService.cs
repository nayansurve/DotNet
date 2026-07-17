namespace HR.Services;
using HrApp;

public interface IPayrollService
{
    void GeneratePayslip(Employee employee);
}