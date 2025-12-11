using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Taskify.Database;

var builder = WebApplication.CreateBuilder(args);

var host = Environment.GetEnvironmentVariable("TASKIFY_DATABASE_HOST");
var port = Environment.GetEnvironmentVariable("TASKIFY_DATABASE_PORT");
var database = Environment.GetEnvironmentVariable("TASKIFY_DATABASE_NAME");
var userName = Environment.GetEnvironmentVariable("TASKIFY_DATABASE_USER");
var password = Environment.GetEnvironmentVariable("TASKIFY_DATABASE_PASSWORD");

var connectionString = $"Host={host};Port={port};Database={database};Username={userName};Password={password};";

builder.Services.AddDbContext<TaskContext>(options =>
    options.UseNpgsql(connectionString));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.UseHttpsRedirection();

app.Run();

