

using HR.Interfaces;
using HrApp;

namespace HrAPp;

public class SalesManager:SalesEmployee,IInterviwePanel,IManagerBenifits,ITrainer
{
    private double bonus;

    public SalesManager(int empId,
    string empName,
    double basicSalary,
    string location,
    double incentive,
    double bonus)
    : base(empId,empName,basicSalary,location,incentive)
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
   
    public double CalculateBonus()
    {
        return bonus;
    }
    public void ConductAppraisable()
    {
        Console.WriteLine("Manager Apprisal Conducted");
    }
    public void  AproveLeave()
    {
        Console.WriteLine("Sales Manager Approve Leave");
    }
     public void TakeInterview()
    {
        Console.WriteLine("Sales Manager Conducting Interview");
    }
    public void Train()
    {
        Console.WriteLine("Sales MAnager team Trianing Employess");
    }
}