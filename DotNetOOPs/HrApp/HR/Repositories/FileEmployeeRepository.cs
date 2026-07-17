using HR;
using HrApp;

namespace HR.Repositories;

public class FileEmployeeRepository : IEmployeeRepository
{
      private readonly List<Employee> _employees=new();
      
       public void Add(Employee employee)
    {
        File.AppendAllText("employee.text",
        $"{employee.empId},{employee.empName},{Environment.NewLine}");
    }

    public void Update(Employee employee)
    {
        var emp=GetById(employee.empId);
        if(emp != null)
        {
            
            _employees.Remove(emp);
            _employees.Add(emp);
            Console.WriteLine("Employee Updated");
        }

    }
     public Employee GetById(int id)
    {

        return _employees.FirstOrDefault(e => e.empId == id);


    }
     public List<Employee> GetByAll()
{
    return _employees;
}

public List<Employee> GetEmployeesByLocation(string location)
{
    List<Employee> result = new List<Employee>();

    foreach (Employee employee in _employees)
    {
        if (employee.location == location)
        {
            result.Add(employee);
        }
    }

    return result;
}

}