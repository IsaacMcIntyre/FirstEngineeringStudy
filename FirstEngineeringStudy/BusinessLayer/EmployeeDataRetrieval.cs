using System;
using FirstEngineeringStudy.ViewModels.Employee;

namespace FirstEngineeringStudy.BusinessLayer
{
    public class EmployeeDataRetrieval : IEmployeeDataRetrieval
    {
        public EmployeeResponseVm[] GetEmployees()
        {
            return new EmployeeResponseVm[0];
        }
    }
}