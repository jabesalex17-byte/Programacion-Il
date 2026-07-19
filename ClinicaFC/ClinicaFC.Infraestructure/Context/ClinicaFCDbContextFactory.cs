using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaFC.Infraestructure.Context
{
    public class ClinicaFCDbContextFactory : IDesignTimeDbContextFactory<ClinicaFCDbContext>
    {
        public ClinicaFCDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ClinicaFCDbContext>();
            optionsBuilder.UseNpgsql(
                "Host=aws-1-us-east-2.pooler.supabase.com;Database=postgres;Username=postgres.ckyzizecchxjrgqxzdkn;Password=GimnaioFVhd29;SSL Mode=Require;Trust Server Certificate=true");

            return new ClinicaFCDbContext(optionsBuilder.Options);
        }


    }
}
