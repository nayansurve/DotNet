namespace EmployeeDemo;

public class SalesEmployee:Employee
{
    public double sales,commision;
 
   public SalesEmployee (double empsalary,double Sales, double Commision):base(empsalary)
    {
        this.sales=Sales;
        this.commision=Commision;
    }

//Shadowing concept
    public new double CalculateSalary()
    {
        return empBasicSalary+sales*commision;
    }
    
}