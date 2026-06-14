using GimnasioFC.Models;
using Microsoft.EntityFrameworkCore;

namespace GimnasioFC.Data
{
    public class DbContextGimnasioFC(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Member> Members { get; set; }
        public DbSet<Coach> Coaches { get; set; }
    }
}
