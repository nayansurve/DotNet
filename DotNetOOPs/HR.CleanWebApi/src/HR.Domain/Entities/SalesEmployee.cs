namespace HR.Domain.Entities;

public class SalesEmployee:Employee
{
    public double empInsentive{get;set;}

    public override double CalculateSalary()
    {
        return 20000 +empInsentive;
    }
}