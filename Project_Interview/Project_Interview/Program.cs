using Microsoft.EntityFrameworkCore;
using Project_Interview.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//建立資料庫連線
builder.Services.AddDbContext<InterviewContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("Interview")));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
