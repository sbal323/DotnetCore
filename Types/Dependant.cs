using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public class Dependant
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Relation { get; set; }
        public string EmergencyPhoneNumber { get; set; }
        //EF Properties
        public Employee Employee { get; set; }
    }
}
