using HrApp;

namespace HrAPp;

public class SalesManager:SalesEmployee
{
    private double bonus;

    public SalesManager(int empId,
    string empName,
    double basicSalary,
    double incentive,
    double bonus)
    : base(empId,empName,basicSalary,incentive)
    {
        this.bonus=bonus;
    }
    public override void DoWork()
    {
        Console.WriteLine("Sales Team is Managed By The Manager");

    }
    public override double ComputePay()
    {
        return base.ComputePay()+bonus;
    }
}