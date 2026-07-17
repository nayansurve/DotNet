using BookApi.Model;
using BookRepo.Repositories;
using BookServices.Services;



var builder = WebApplication.CreateBuilder(args);

// Add Services
builder.Services.AddControllers();

// Register Dependency Injection
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IBookService, BookService>();


var app = builder.Build();



app.UseHttpsRedirection();

app.MapControllers();

app.Run();