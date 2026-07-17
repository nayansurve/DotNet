using Microsoft.AspNetCore.Mvc;
using HR.Application.Services;
using HR.Domain.Entities;
namespace HR.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private readonly EmployeeService service;

    public EmployeeController(EmployeeService service)
    {
        this.service = service;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(service.GetEmployees());
    }

    [HttpPost]
public IActionResult Hire([FromBody] SalesEmployee employee)
{
    service.Hire(employee);
    return Ok("Employee Added Successfully");
}
}