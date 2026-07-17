// using HR;
// using HrApp;
// namespace HR.Repositories;

// public class InMemoryEmployeeRepository:IEmployeeRepository
// {
//     private readonly List<Employee> _employees=new();
//     public void Add(Employee employee)
//     {
//         _employees.Add(employee);
//         Console.WriteLine("Employees Added Successfully");
//     }
//     public void Update( Employee employee)
//     {
//         var emp=GetById(employee.empId);
//         if(emp != null)
//         {
            
//             _employees.Remove(emp);
//             _employees.Add(emp);
//             Console.WriteLine("Employee Updated");
//         }

//     }
//     public Employee GetById(int id)
//     {
//           return _employees.FirstOrDefault(e => e.empId == id);
//     }
//      public List<Employee> GetByAll()
// {
//     return _employees;
// }
// }
