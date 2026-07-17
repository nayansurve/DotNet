namespace HR.Domain.Entities;

public class SalesManager:SalesEmployee
{ 
    public double empBonus;

    public override double CalculateSalary()
    {
       return 60000+empBonus;
    }
    
}