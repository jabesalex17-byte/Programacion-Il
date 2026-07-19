using ClinicaFC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Infraestructure.Context
{
    public class ClinicaFCDbContext(DbContextOptions<ClinicaFCDbContext> options) : DbContext(options)
    {
        public DbSet<Role> Roles => Set<Role>();

        public DbSet<Specialty> Specialties => Set<Specialty>();

        public DbSet<User> Users => Set<User>();

        public DbSet<Doctor> Doctors => Set<Doctor>();

        public DbSet<Patient> Patients => Set<Patient>();

        public DbSet<Appointment> Appointments => Set<Appointment>();

        public DbSet<Consultation> Consultations => Set<Consultation>();

        public DbSet<Diagnosis> Diagnoses => Set<Diagnosis>();

        public DbSet<Medication> Medications => Set<Medication>();

        public DbSet<Prescription> Prescriptions => Set<Prescription>();
    }
}
