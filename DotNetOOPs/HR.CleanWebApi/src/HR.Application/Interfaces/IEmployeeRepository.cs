using HR.Domain.Entities;
namespace HR.Application.Interfaces;
public interface IEmployeeRepository
{
    void Add(Employee employee);

    List<Employee> GetAll();

    Employee GetById(int id);
}