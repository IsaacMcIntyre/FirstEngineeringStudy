using System;
using System.ComponentModel.DataAnnotations;

namespace FirstEngineeringStudy.DataLayer.DataModels
{
    public class Employee
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime AndStartDate { get; set; }
        public virtual Club Club { get; set; }
        public virtual DrivingLicense DrivingLicense { get; set; }
        public bool isDeleted { get; set; }
    }
}
