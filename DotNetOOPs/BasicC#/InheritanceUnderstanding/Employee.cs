namespace Inheritance;

public  class Employee
{
    public int empId;
  public string empName;

    public double empBasicSalary;

   public double Hra;

   public double Da;


//Constructor Overloading 
    public Employee()
    {
        empId=101;
        empName="Sarthak";
        empBasicSalary=40000;
        Hra=20000;
        Da=10000;

    }

    public Employee(int empid,string empname,double empbasicsalary,double hra,double da)
    {
        this.empId=empid;
        this.empName=empname;
        this.empBasicSalary=empbasicsalary;
        this.Hra=hra;
        this.Da=da;

    }

    public virtual double CalculateSalary()
    {
        return empBasicSalary+Hra+Da; 
    }

      public override string ToString(){
      return base.ToString() +
      "Basic Salary ="+ this.empBasicSalary +
      "hra ="+ this.Hra +
      "da="+ this.Da;
    }
   
   
}
