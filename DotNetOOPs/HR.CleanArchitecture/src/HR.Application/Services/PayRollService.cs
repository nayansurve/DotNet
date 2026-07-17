using HR.Domain.Entities;
using HR.Application.Interface;
namespace HR.Application.Services;

public class PayRollService:IPayrollService
{
    public void GeneratePayslip(Employee employee)
    {
        Console.WriteLine("Slip Generated");
    }
}