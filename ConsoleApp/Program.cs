using Dal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Types;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            using(CoreHrContext context = new CoreHrContext())
            {
                context.Database.Migrate();
                //Console.WriteLine("DB Migration completed");
                //context.Employees.Add(new Types.Employee()
                //{
                //    FirstName = "Sergii",
                //    LastName = "Balog",
                //    DateOfBirth = new DateTime(1978, 12, 18),
                //    EmploymentDate = new DateTime(2008, 5, 1),
                //    SalaryDetails = new Types.EmployeeSalaryDetails()
                //    {
                //        BaseSalary = 3000,
                //        PaymentFrequency = Types.PaymentFrequency.Monthly,
                //        AnnualVariableSalary = 5000
                //    },
                //    Dependants = new List<Types.Dependant>()
                //    {
                //        new Dependant()
                //        {
                //            FirstName = "Kateryna",
                //            LastName = "Balog",
                //            Relation = "Daughter"
                //        },
                //        new Dependant()
                //        {
                //            FirstName = "Iryna",
                //            LastName = "Balog",
                //            EmergencyPhoneNumber = "+380684359045",
                //            Relation = "Wife"
                //        }
                //    },
                //    EmployeeCompetencies = new List<EmployeeCompetencies>()
                //    {
                //        new EmployeeCompetencies()
                //        {
                //            Competency = new Competency()
                //            {
                //                Title = "Leadership",
                //                Description = "Leadership competency"
                //            }
                //        },
                //        new EmployeeCompetencies()
                //        {
                //            Competency = new Competency()
                //            {
                //                Title = "C#",
                //                Description = "C# programming language"
                //            }
                //        }
                //    }
                //});
                //context.SaveChanges();
                //
                //
                //Employee empl = context.Employees.Include(x => x.EmployeeCompetencies).ThenInclude(x => x.Competency).Where(x => x.FirstName.StartsWith("Serg")).FirstOrDefault();
                //if (empl != null)
                //{

                //    var emploCompetencies = empl.EmployeeCompetencies.Select(x => new { Name = x.Employee.FirstName + " " + x.Employee.LastName, Competency = x.Competency.Title, Score = x.Score });
                //    foreach (var ec in emploCompetencies)
                //    {
                //        Console.WriteLine(ec.Name + "\t" + ec.Competency + "\t" + ec.Score);
                //    }
                //}
                //
                //
                //Employee empl = context.Employees.Include(x => x.SalaryDetails).Where(x => x.FirstName.StartsWith("Serg")).FirstOrDefault();
                //if (empl != null)
                //{

                //    empl.SalaryDetails.BaseSalary = 1000;
                //    context.SaveChanges();
                //}
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
