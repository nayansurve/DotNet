
namespace HrApp;
public class SalesEmployee:Employee
{
     private double incentive;
    public SalesEmployee(int empId,
    string empName,
    double basicSalary,
    double incentive )
    : base( empId, empName,basicSalary)
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
}