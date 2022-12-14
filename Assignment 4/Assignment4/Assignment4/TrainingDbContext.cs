using Assignment4.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    public class TrainingDbContext : DbContext
    {
        private readonly string _connectionString;
        private readonly string _migrationAssembly;
        public TrainingDbContext()
        {
            _connectionString = @"Server = DESKTOP-UARLHUC\SQLEXPRESS; Database = Csharpb12; Trusted_Connection = True;";
            _migrationAssembly = Assembly.GetExecutingAssembly().GetName().Name;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString, (x) => x.MigrationsAssembly(_migrationAssembly));
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

         public DbSet<User> Users { get; set; }
         public DbSet<Course> courses { get; set; }


    }
}
