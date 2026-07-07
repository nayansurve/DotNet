namespace HrApp;
public abstract class Employee
{
    protected int empId;
    protected string empName;
    protected double basicSalary;

    public Employee(int empId,string empName,double basicSalary)
    {
        this.empId=empId;
        this.empName=empName;
        this.basicSalary=basicSalary;
    }

    public abstract void DoWork();

    public virtual double ComputePay()
    {
        return basicSalary;
    }

}