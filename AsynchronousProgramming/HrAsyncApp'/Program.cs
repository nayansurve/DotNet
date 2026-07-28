// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();
// app.Run();
using HR.Models;
using HR.Services;

public class Program
{
    static async Task Main()
    {
        Console.WriteLine("HR System Started....\n");

        HROperationService service=new HROperationService();

        var Employees=await service.GetEmployeeAsync();

        Console.WriteLine("Employee Loaded:");
        Employees.ForEach(e =>Console.WriteLine(e));

        Console.WriteLine("\n Calculating Bonus for All EMployee Asynchronously");
        // double bonus=await service.CalculateBonusAsync(Employees[0]);
        // Console.WriteLine($"Bonus for {Employees[0].Name} : {bonus}");
         Task<double>[] bonusTask=new Task<double>[Employees.Count];
         for(int i=0;i<Employees.Count;i++)
        {
            bonusTask[i]=service.CalculateBonusAsync(Employees[i]);
        }
        double[] bonuses=await Task.WhenAll(bonusTask);

        for(int i=0;i<Employees.Count;i++)
        {
            Console.WriteLine($"{Employees[i].Name} Bonus = {bonuses[i]}");
        }
        await service.SaveEmployeeAsync(Employees[0]);

        Console.WriteLine("\nHr Sysytem Completed");

        Employee emp=await service.GetEmployeeByIdAsync(102);

        if(emp != null)
        {
            Console.WriteLine("Employee Found :");
            Console.WriteLine(emp);

        }
        else
        {
            Console.WriteLine("Employee Not Found");
        }
    }
}