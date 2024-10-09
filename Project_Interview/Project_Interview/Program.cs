using Microsoft.EntityFrameworkCore;
using Project_Interview.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//�إ߸�Ʈw�s�u
builder.Services.AddDbContext<InterviewContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("Interview")));


var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
