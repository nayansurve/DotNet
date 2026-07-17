namespace HrApp;
public abstract class Employee
{
    public int empId;
    public string empName;
    public double basicSalary;

    public string location;

    public Employee(int empId,string empName,double basicSalary,string location)
    {
        this.empId=empId;
        this.empName=empName;
        this.basicSalary=basicSalary;
        this.location=location;
    }

    public abstract void DoWork();

    public virtual double ComputePay()
    {
        return basicSalary;
    }
public override string ToString()
{
   
    return $"Employee ID: {empId}, Name: {empName}, Basic Salary: {basicSalary},Location:{location}";
}
}