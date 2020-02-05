using FirstEngineeringStudy.ViewModels.Employee;

namespace FirstEngineeringStudy.BusinessLayer
{
    public interface IEmployeeDataRetrieval
    {
        EmployeeResponseVm[] GetEmployees();
    }
}