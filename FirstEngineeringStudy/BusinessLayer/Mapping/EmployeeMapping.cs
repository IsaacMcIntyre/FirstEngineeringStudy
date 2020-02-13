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
            if (employee == null)
            {
                throw new ArgumentException("Employee must not be null.");
            }
            return new EmployeeResponseVm(employee.EmployeeId, employee.Email, employee.EmployeeNumber, employee.FullName, employee.DOB, employee.StartDate, employee.Salary);
        }

        public EmployeeResponseVm[] DataModelToRetrievalViewModel(Employee[] employees)
        {
            return employees.Select(employee => DataModelToRetrievalViewModel(employee)).ToArray();
        }
    }

    public interface IEmployeeMapping
    {
        public EmployeeResponseVm DataModelToRetrievalViewModel(Employee employee);
        public EmployeeResponseVm[] DataModelToRetrievalViewModel(Employee[] employees);

    }

}
