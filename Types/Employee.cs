using System;
using System.Collections.Generic;

namespace Types
{
    public class Employee
    {
        public Employee()
        {
            SalaryDetails = new EmployeeSalaryDetails();
            Dependants = new List<Dependant>();
            EmployeeCompetencies = new List<EmployeeCompetencies>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime EmploymentDate { get; set; }
        // EF Properties
        public EmployeeSalaryDetails SalaryDetails { get; set; }
        public List<Dependant> Dependants { get; set; }
        public List<EmployeeCompetencies> EmployeeCompetencies { get; set; }
    }
}
