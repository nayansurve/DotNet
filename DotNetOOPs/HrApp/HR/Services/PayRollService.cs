namespace HR.Services;
using HrApp;

public class PayRollService:IPayrollService
{
    public void GeneratePayslip(Employee employee)
    {
        Console.WriteLine("Slip Generated");
    }
}