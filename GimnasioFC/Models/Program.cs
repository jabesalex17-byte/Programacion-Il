using GimnasioFC.Data;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;

var builder = WebApplication.CreateBuilder(args);

var MyConfigurationString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<DbContextGimnasioFC>(op =>
{
    op.UseSqlServer(MyConfigurationString);
});

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapSwagger();
app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

//app.UseHttpsRedirection();


app.Run();
