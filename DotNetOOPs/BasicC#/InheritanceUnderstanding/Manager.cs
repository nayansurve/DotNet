namespace Inheritance;

// this is the derived class 
public class Manager:Employee
{
   private double Incentive;

   public Manager():base()
    {
        Incentive=1000;
    }

    public Manager(int empId,string empName,double empBasicSalary,double Hra,double Da,double incentive):
    base(empId,empName,empBasicSalary,Hra,Da)
    {
        this.Incentive=incentive;
    }
    public double CalculateIncentive()
    {
        return Incentive*2;
    }

    public override double CalculateSalary()
    {
        return empBasicSalary + Hra + Da+ CalculateIncentive();
     
    }
    public override string ToString()
    {
        return base.ToString()+
        "Incentive"+this.Incentive;
    }
}