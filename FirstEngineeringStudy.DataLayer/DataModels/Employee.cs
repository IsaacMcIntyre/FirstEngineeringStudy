using System;
using System.Collections.Generic;
using System.Text;

namespace FirstEngineeringStudy.DataLayer.DataModels
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Email { get; set; }
        public int EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime StartDate { get; set; }
        public float Salary { get; set; }
        public int ClubId { get; set; }
        public int LicenseId { get; set; }
    }
}