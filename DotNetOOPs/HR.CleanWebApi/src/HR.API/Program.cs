using HR.Application.Interfaces;
using HR.Application.Services;
using HR.Infrastructure.Repositiories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();


builder.Services.AddSingleton<IEmployeeRepository, InMemoryRepository>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<PayrollService>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Map Controllers
app.MapControllers();

app.Run();