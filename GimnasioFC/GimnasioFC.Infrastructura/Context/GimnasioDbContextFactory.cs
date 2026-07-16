using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Infrastructura.Context
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<GimnasioDbContext>
    {
        public GimnasioDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<GimnasioDbContext>();
            optionsBuilder.UseNpgsql(
                "Host=aws-1-us-east-2.pooler.supabase.com;Database=postgres;Username=postgres.ckyzizecchxjrgqxzdkn;Password=GimnaioFVhd29;SSL Mode=Require;Trust Server Certificate=true");

            return new GimnasioDbContext(optionsBuilder.Options);
        }
    }
}
