namespace DelegateDemo;
delegate void MyDelagate();
public class Employee
{
    public int EmpId;

    public string EmpName;

    public Employee(int empid,string empname)
    {
        this.EmpId=empid;
        this.EmpName=empname;
    }

   public  void Display()
    {
        Console.WriteLine("******Student Details ****");
       Console.WriteLine($"Id = {EmpId} ANd Name ={EmpName}");
    }
}