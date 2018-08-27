using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public class EmployeeCompetencies
    {
        public int CompetencyId { get; set; }
        public int EmployeeId { get; set; }
        public float Score { get; set; }
        // EF Properties
        public Competency Competency { get; set; }
        public Employee Employee { get; set; }

    }
}
