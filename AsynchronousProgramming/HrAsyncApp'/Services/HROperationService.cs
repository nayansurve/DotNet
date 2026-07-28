using HR.Models;
namespace HR.Services;

public class HROperationService
{
    public async Task<List<Employee>> GetEmployeeAsync()
    {
        await Task.Delay(5000);

        return new List<Employee>
        {
            new Employee {Id=101,Name="Naina",Department="IT",Salary=50000},
            new Employee {Id=102,Name="Sarthak",Department="IT",Salary=60000},
            new Employee {Id=103,Name="Shriyansh",Department="MBBS",Salary=80000}
        };
    }
    public async Task<Employee> GetEmployeeByIdAsync(int id)
    {
        await Task.Delay(2000);

        List<Employee> employees=await GetEmployeeAsync();
        return employees.Find(e => e.Id==id);
    }

    public async Task<double> CalculateBonusAsync(Employee emp)
    {
        await Task.Delay(2000);
        return emp.Salary * 0.10;
    }

    public async Task SaveEmployeeAsync(Employee emp)
    {
        await Task.Delay(1500);
        Console.WriteLine($"Employee Saved Asynchrpnously : {emp.Name}");
    }
}