using System;
using System.Linq;
using FirstEngineeringStudy.BusinessLayer.Mapping;
using FirstEngineeringStudy.DataLayer.Contexts;
using FirstEngineeringStudy.ViewModels.Employee;

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
            var employeeMapping = new EmployeeMapping();
            return employeeMapping.DataModelToRetrievalViewModel(employees);
        }
    }
}
