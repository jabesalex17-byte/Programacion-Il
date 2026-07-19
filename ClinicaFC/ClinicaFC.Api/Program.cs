using ClinicaFC.Application.Interfaces;
using ClinicaFC.Application.Services;
using ClinicaFC.Domain.Repository;
using ClinicaFC.Infraestructure.Context;
using ClinicaFC.Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

builder.Services.AddDbContext<ClinicaFCDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<ISpecialtyRepository, SpecialtyRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IPatientRepository, PatientRepository>();
builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<IConsultationRepository, ConsultationRepository>();
builder.Services.AddScoped<IDiagnosisRepository, DiagnosisRepository>();
builder.Services.AddScoped<IMedicationRepository, MedicationRepository>();
builder.Services.AddScoped<IPrescriptionRepository, PrescriptionRepository>();


builder.Services.AddScoped<IRoleServices, RoleService>();
builder.Services.AddScoped<ISpecialtyServices, SpecialtyService>();
builder.Services.AddScoped<IUserServices, UserService>();
builder.Services.AddScoped<IDoctorServices, DoctorService>();
builder.Services.AddScoped<IPatientServices, PatientService>();
builder.Services.AddScoped<IAppointmentServices, AppointmentService>();
builder.Services.AddScoped<IConsultationServices, ConsultationService>();
builder.Services.AddScoped<IDiagnosisServices, DiagnosisService>();
builder.Services.AddScoped<IMedicationServices, MedicationService>();
builder.Services.AddScoped<IPrescriptionServices, PrescriptionService>();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
