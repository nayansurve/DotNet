using HR.Domain.Entities;

namespace HR.Application.Interface;

public interface IEmployeeRepository
{
    void Add(Employee employee);
    void Update(Employee employee);
    Employee GetById(int id);
        List<Employee>GetByAll();

        List<Employee> GetEmployeesByLocation(string location);

}
//here interface repositiers only tells what opeations to perform it did not tell how ....... 
