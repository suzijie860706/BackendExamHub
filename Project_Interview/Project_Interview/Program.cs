using Microsoft.EntityFrameworkCore;
using Project_Interview.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//�إ߸�Ʈw�s�u
builder.Services.AddDbContext<InterviewContext>(option =>
    option.UseSqlServer(builder.Configuration.GetConnectionString("Interview")));

//���USwagger
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // ���w���|�� ""
    });
}

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
