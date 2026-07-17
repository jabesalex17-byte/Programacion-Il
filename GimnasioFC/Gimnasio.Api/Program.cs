using GimnasioFC.Application.Interfaces.Repository;
using GimnasioFC.Application.Interfaces.Service;
using GimnasioFC.Application.Services;
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
builder.Services.AddScoped<ICoachServices, CoachServices>();

builder.Services.AddScoped<IMemberRepository, MemberRepository>();
builder.Services.AddScoped<IMemberServices, MemberServices>();

builder.Services.AddScoped<ISubscriptionRepository, SubcriptionRepository>();
builder.Services.AddScoped<ISubscriptionServices, SubcriptionServices>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeServices, EmployeeServices>();

//builder.Services.AddScoped<IMemberRepository, CoachServices>();
//builder.Services.AddScoped<ICoachServices, CoachServices>();
//builder.Services.AddScoped<ICoachServices, CoachServices>();


builder.Services.AddSwaggerGen();


var app = builder.Build();

//app.UseHttpsRedirection();
app.MapSwagger();
app.UseSwaggerUI();




app.MapControllers();

app.Run();
