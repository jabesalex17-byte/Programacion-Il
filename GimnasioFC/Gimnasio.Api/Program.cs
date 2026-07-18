using GimnasioFC.Infrastructura.Interfaces.Repository;
using GimnasioFC.Infrastructura.Context;
using GimnasioFC.Infrastructura.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();




var MyConnectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<GimnasioDbContext>(option =>
{
    option.UseNpgsql(MyConnectionString);
});

builder.Services.AddScoped<ICoachRepository, CoachRepository>();
builder.Services.AddScoped<IMemberRepository, MemberRepository>();
builder.Services.AddScoped<ISubscriptionRepository, SubcriptionRepository>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddSwaggerGen();


var app = builder.Build();

//app.UseHttpsRedirection();
app.MapSwagger();
app.UseSwaggerUI();




app.MapControllers();

app.Run();
