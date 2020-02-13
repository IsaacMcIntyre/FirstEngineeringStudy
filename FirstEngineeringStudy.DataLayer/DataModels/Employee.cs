using System;
using System.Collections.Generic;
using System.Text;

namespace FirstEngineeringStudy.DataLayer.DataModels
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(int employeeId, string email, int employeeNumber, string fullName, DateTime dob, DateTime startDate, float salary, int clubId, int licenseId)
        {
            EmployeeId = employeeId;
            Email = email;
            EmployeeNumber = employeeNumber;
            FullName = fullName;
            DOB = dob;
            StartDate = startDate;
            Salary = salary;
            ClubId = clubId;
            LicenseId = licenseId;
        }

        public int EmployeeId { get; set; }
        public string Email { get; set; }
        public int EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime StartDate { get; set; }
        public float Salary { get; set; }
        public int ClubId { get; set; }
        public int LicenseId  { get; set; }
    }
}
