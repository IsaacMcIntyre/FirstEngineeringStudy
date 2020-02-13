using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstEngineeringStudy.DataLayer.DataModels;
using FirstEngineeringStudy.ViewModels.Employee;

namespace FirstEngineeringStudy.BusinessLayer.Mapping
{
    public class EmployeeMapping : IEmployeeMapping
    {
        public EmployeeResponseVm DataModelToRetrievalViewModel(Employee employee)
        {
            return new EmployeeResponseVm();
        }


    }

    public interface IEmployeeMapping
    {
        public EmployeeResponseVm DataModelToRetrievalViewModel(Employee employee);

    }

}
