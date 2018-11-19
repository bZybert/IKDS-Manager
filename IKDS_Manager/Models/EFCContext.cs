using IKDS_Manager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IKDDS_Manager.Models
{
    public class EFCContext : IdentityDbContext
    {
       public DbSet<IKDDSModel> IKDDSModels { get; set; }
      // public DbSet<InvestigationInitiateType> InvestigationInitiateTypes { get; set; }
       public DbSet<InvestigationType> InvestigationType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Data Source=.\SQLEXPRESS;Initial Catalog=IKDDSBase;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
