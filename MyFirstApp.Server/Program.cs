using System.Security.Policy;
using Microsoft.EntityFrameworkCore;
using MyFirstApp.Server.Controllers;
using MyFirstApp.Server.Storage;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var Builder= builder.Services.AddDbContext<RepositoryDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"));
    
});

builder.Services.AddScoped<RepositoryDbContext>();
builder.Services.AddScoped<CustomerController.CustomersController>();
builder.Services.AddScoped<ChachierController.ChachierController>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
