using MyFirstProject.Interfaces;
using MyFirstProject.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container - Web API
builder.Services.AddControllers();

// Register custom services
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
