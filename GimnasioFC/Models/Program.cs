using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Logging.Abstractions;
 
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapSwagger();
app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

//app.UseHttpsRedirection();


app.Run();
