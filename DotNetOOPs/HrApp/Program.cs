using HrApp;

using HR.Repositories;

using HR.Interfaces;

using HR.Services;
using HrAPp;
using System.Data.Common;

public class Program
{
    public static void Main(string[] args)
    {
        Employee emp1 = new SalesEmployee(101, "Sarthak", 50000,"Pune" ,70000);

        Employee emp2 = new SalesManager(102, "Naina", 40000,"Mumbai" ,600000, 300000 );
         Console.WriteLine();
          Console.WriteLine();
         
        Console.WriteLine("Sales Employee");
        emp1.DoWork();
        Console.WriteLine("Salary = " + emp1.ComputePay());

       Console.WriteLine();

        Console.WriteLine("Sales Manager");
        emp2.DoWork();
        Console.WriteLine("Salary = " + emp2.ComputePay());

        Console.WriteLine();

       SalesManager sm=new SalesManager( 101,
    "Nayan",
    50000,
    "Pune",
    5000,
    10000);
    Console.WriteLine();

        IAppraisable appraisable=sm;
        appraisable.ConductAppraisable();

        Console.WriteLine();

       IBonusEligible eligible=sm;
       eligible.CalculateBonus();
       Console.WriteLine("Bonus = " +eligible.CalculateBonus());

    Console.WriteLine();
       IInterviwePanel ip=sm;
       ip.TakeInterview();

       Console.WriteLine();

       ITrainer it=sm;
       it.Train();

 Console.WriteLine();
   // here we need to create to the dependency
   IEmployeeRepository employeeRepository=new FileEmployeeRepository();

   IEmployeeService service=new EmployeeService(employeeRepository);
    Console.WriteLine();
   IPayrollService payrollService=new PayRollService();
    Console.WriteLine();

   // then here we connect the dependency
   HRProcessor processor=new HRProcessor(service,payrollService);
    Console.WriteLine();

   

    service.AddEmployee(emp1);
    service.AddEmployee(emp2);
    
    foreach (var emp in service.GetEmployees())
{
    processor.Process(emp);
}

      processor.Process(emp1);
       Console.WriteLine();
      processor.Process(emp2);
    }


    
}