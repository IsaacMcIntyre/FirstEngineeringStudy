using System;
namespace FirstEngineeringStudy.ViewModels.Employee
{
    public class EmployeeResponseVm
    {
        public EmployeeResponseVm()
        {
        }
        public EmployeeResponseVm(int employeeId, string email, int employeeNumber, string fullName, DateTime dob, DateTime startDate, float salary)
        {
            EmployeeId = employeeId;
            Email = email;
            EmployeeNumber = employeeNumber;
            FullName = fullName;
            DOB = dob;
            StartDate = startDate;
            Salary = salary;
        }

        public int EmployeeId { get; set; }
        public string Email { get; set; }
        public int EmployeeNumber { get; set; }
        public string FullName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime StartDate { get; set; }
        public float Salary { get; set; }

    }
}
