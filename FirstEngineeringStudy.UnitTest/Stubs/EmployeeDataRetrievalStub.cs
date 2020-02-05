using System;
using FirstEngineeringStudy.BusinessLayer;
using FirstEngineeringStudy.ViewModels.Employee;

namespace FirstEngineeringStudy.UnitTest.Stubs
{
    public class EmployeeDataRetrievalStub : IEmployeeDataRetrieval
    {
        public EmployeeDataRetrievalStub()
        {
        }

        public EmployeeResponseVm[] GetEmployees()
        {
            return new EmployeeResponseVm[0];
        }
    }
}
