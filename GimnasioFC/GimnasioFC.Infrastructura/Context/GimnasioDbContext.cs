using GimnasioFC.Domain.Entities;
using GimnasioFC.Infrastructura.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GimnasioFC.Infrastructura.Context
{
    public class GimnasioDbContext(DbContextOptions<GimnasioDbContext>  options) : DbContext(options)
    {
        public DbSet<MemberModel> Members { get; set; }
        public DbSet<CoachModel> Coaches { get; set; }
        public DbSet<SubscriptionModel> Subscriptions { get; set; }
        public DbSet<EmployeeModel> Employees { get; set; }
    }

}
