using HR.Application.Interfaces;
using HR.Domain.Entities;

namespace HR.Infrastructure.Repositiories;

public class InMemoryRepository : IEmployeeRepository
{
    private List<Employee> employees =
        new List<Employee>();

    public void Add(Employee employee)
    {
        employees.Add(employee);
    }

    public List<Employee> GetAll()
    {
        return employees;
    }

    public Employee GetById(int id)
    {
        return employees.FirstOrDefault(e=>e.empId==id);
    }
}