using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Collections.Generic;
using System.Text;
using Types;

namespace Dal
{
    public class CoreHrContext: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSalaryDetails> SalaryDetails { get; set; }

        public static readonly LoggerFactory DalLoggerFactory = new LoggerFactory(new[] {
            new ConsoleLoggerProvider((category, level)
                => category == DbLoggerCategory.Database.Command.Name
                   && level == LogLevel.Information, true) });
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLoggerFactory(DalLoggerFactory)
                .UseSqlServer("Server=(local);Database=CoreHr;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // One to one
            modelBuilder.Entity<Employee>()
                .HasOne(a => a.SalaryDetails)
                .WithOne(b => b.Employee)
                .HasForeignKey<EmployeeSalaryDetails>(b => b.EmployeeId);
            // One to many
            modelBuilder.Entity<Employee>()
               .HasMany(c => c.Dependants)
               .WithOne(e => e.Employee);
            //Many to many
            modelBuilder.Entity<EmployeeCompetencies>().HasKey(x => new { x.EmployeeId, x.CompetencyId });
            modelBuilder.Entity<EmployeeCompetencies>()
                 .HasOne(bc => bc.Employee)
                 .WithMany(b => b.EmployeeCompetencies)
                 .HasForeignKey(bc => bc.EmployeeId);
            modelBuilder.Entity<EmployeeCompetencies>()
                .HasOne(bc => bc.Competency)
                .WithMany(c => c.EmployeeCompetencies)
                .HasForeignKey(bc => bc.CompetencyId);
            //default 
            modelBuilder.Entity<EmployeeCompetencies>()
                .Property(x=> x.Score)
                .HasDefaultValue(0);
            // readonly property
            modelBuilder.Entity<EmployeeSalaryDetails>()
               .Property(x => x.AnnualTotalSalary)
               .HasField("_annualTotalSalary");
            modelBuilder.Entity<EmployeeSalaryDetails>()
               .Property(x => x.AnnualBaseSalary)
               .HasField("_annualBaseSalary");
            base.OnModelCreating(modelBuilder);
        }
    }
}
