using Service;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Configure the HTTP request pipeline.



app.MapGet("/api/product", () =>
{
    return ProductService.GetAll();
});

app.MapPut("/api/product" , () =>
{
    return ProductService.Insert();
});



app.Run();


