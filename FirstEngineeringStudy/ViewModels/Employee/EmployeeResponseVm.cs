using FirstEngineeringStudy.ViewModels.Club;
using FirstEngineeringStudy.ViewModels.DrivingLicense;
using System;
namespace FirstEngineeringStudy.ViewModels.Employee
{
    public class EmployeeResponseVm
    {
        public EmployeeResponseVm(int Id, string Email, string FullName, DateTime DateOfBirth, DateTime AndStartDate, ClubVm Club, DrivingLicenseVm DrivingLicense) 
        {
            this.Id = Id;
            this.Email = Email;
            this.FullName = FullName;
            this.DateOfBirth = DateOfBirth;
            this.AndStartDate = AndStartDate;
            this.Club = Club;
            this.DrivingLicense = DrivingLicense;
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime AndStartDate { get; set; }
        public ClubVm Club { get; set; }
        public DrivingLicenseVm DrivingLicense { get; set; }
    }
}
