using System;
using System.Collections.Generic;
using System.Text;

namespace FirstEngineeringStudy.DataLayer.DataModels
{
    public class DrivingLicense
    {
        public int Id { get; set; }
        public virtual DateTime IssueDate { get; set; }
        public int PointsReceived { get; set; }
        public bool isDeleted { get; set; }
    }
}
