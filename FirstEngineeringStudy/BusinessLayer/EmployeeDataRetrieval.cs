using System;
using System.Linq;
using FirstEngineeringStudy.DataLayer.Contexts;
using FirstEngineeringStudy.DataLayer.DataModels;
using FirstEngineeringStudy.ViewModels.Club;
using FirstEngineeringStudy.ViewModels.Employee;
using FirstEngineeringStudy.ViewModels.DrivingLicense;

namespace FirstEngineeringStudy.BusinessLayer
{
    public class EmployeeDataRetrieval : IEmployeeDataRetrieval
    {
        private readonly IDatabaseContext _context;
        public EmployeeDataRetrieval(IDatabaseContext databaseContext)
        {
            _context = databaseContext;
        }

        public EmployeeResponseVm[] GetEmployees()
        {
            var employees = _context.Employees.ToArray();

            return employees.Select(x =>
            {
                const ClubVm ClubVm = new ClubVm(x.Club.Id, x.Club.Name);

                const DrivingLicenseVm DrivingLicenseVm = new DrivingLicenseVm(x.DrivingLicense.Id, x.DrivingLicense.IssueDate, x.DrivingLicense.PointsReceived);
                return new EmployeeResponseVm(x.Id, x.Email, x.FullName, x.DateOfBirth, x.AndStartDate, ClubVm, DrivingLicenseVm).ToArray();
            }
            );
            //needs t0 construct for AndClubVm
            //needs t0 construct for DrivingLicenseVm
            //Needs to then put that into a new EmployeeResponseVm

        }
    }
}