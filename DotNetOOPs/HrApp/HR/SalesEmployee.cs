using HR.Interfaces;
namespace HrApp;
public class SalesEmployee:Employee , IAppraisable
{
    private double incentive;
    public SalesEmployee(int empId,
    string empName,
    double basicSalary,
    string location,
    double incentive )
    : base( empId, empName,basicSalary,location)
    {
        this.incentive=incentive;
    }
    public override void DoWork()
    {
        Console.WriteLine("sales employee sales products");
    }
    public override double ComputePay()
    {
        return basicSalary+incentive;
    }
  
    public void ConductAppraisable()
    {
        Console.WriteLine("Sales Emplyee Appriasable completed");
    }

}