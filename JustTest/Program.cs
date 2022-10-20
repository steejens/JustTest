using JustTest;
using JustTest.Commands;
using JustTest.Entities;
using JustTest.Queries;
using JustTest.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultPostgres")));
builder.Services.AddScoped<ITestRepository,TestRepository>();
builder.Services.AddScoped<CreateTestCommand>();
builder.Services.AddScoped<GetTestByIdQuery>();
builder.Services.AddScoped<GetAllTestsQuery>();

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
