using Microsoft.EntityFrameworkCore;
using ProjectAllocation.API.Configurations;
using ProjectAllocation.Repository.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var provider = new DatabaseProvider(builder.Configuration);
string connectionString = provider.GetConnectionString();

builder.Services.AddDbContext<ProjectAllocationContext>(options =>
options.UseNpgsql(
        connectionString,
        b => b.MigrationsAssembly("ProjectAllocation.Repository")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
