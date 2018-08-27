using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public class EmployeeSalaryDetails
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public decimal BaseSalary { get; set; }
        public PaymentFrequency PaymentFrequency { get; set; }
        public decimal AnnualVariableSalary { get; set; }
        private decimal _annualBaseSalary;
        public decimal AnnualBaseSalary
        {
            get
            {
                if (PaymentFrequency == PaymentFrequency.Yearly)
                {
                    return BaseSalary;
                }
                else if (PaymentFrequency == PaymentFrequency.Monthly)
                {
                    return BaseSalary * 12;
                }
                else if (PaymentFrequency == PaymentFrequency.Weekly)
                {
                    return BaseSalary * 52;
                }
                else if (PaymentFrequency == PaymentFrequency.BiWeekly)
                {
                    return BaseSalary * 26;
                }
                else if (PaymentFrequency == PaymentFrequency.SemiMonthly)
                {
                    return BaseSalary * 24;
                }
                else
                {
                    return 0;
                }
            }
        }
        private decimal _annualTotalSalary;
        public decimal AnnualTotalSalary
        {
            get
            {
                return AnnualBaseSalary + AnnualVariableSalary;
            }
        }
        //EF
        public Employee Employee { get; set; }
    }
}
