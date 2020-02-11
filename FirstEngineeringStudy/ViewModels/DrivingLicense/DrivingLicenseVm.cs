using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEngineeringStudy.ViewModels.DrivingLicense
{
    public class DrivingLicenseVm
    {
        public DrivingLicenseVm(int Id, DateTime IssueDate, int PointsReceived)
        {
            this.Id = Id;
            this.IssueDate = IssueDate;
            this.PointsReceived = PointsReceived;
        }
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public int PointsReceived { get; set; }
    }
}
