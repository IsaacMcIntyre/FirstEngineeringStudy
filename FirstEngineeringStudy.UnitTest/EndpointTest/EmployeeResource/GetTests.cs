using System.Threading.Tasks;
using FirstEngineeringStudy.BusinessLayer;
using FirstEngineeringStudy.Controllers;
using FirstEngineeringStudy.UnitTest.Stubs;
using FirstEngineeringStudy.ViewModels.Employee;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NUnit.Framework;

namespace FirstEngineeringStudy.UnitTest.EndpointTest.EmployeeResource
{
    [TestFixture]
    public class GetTests
    {
        [Test]
        public async Task SuccessfulExecutionReturnsCollectionOfTypeEmployeeVm()
        {
            //Arrange
            var employeeController = new EmployeeController(new EmployeeDataRetrievalStub());

            //Act
            var response = await employeeController.Get();

            //Assert
            Assert.IsInstanceOf<ActionResult<EmployeeResponseVm[]>>(response);
        }

        [Test]
        public async Task BusinessLayerMustBeCalledToRetrieveData()
        {
            //Arrange
            var iEmployeeDataRetrieval = Substitute.For<IEmployeeDataRetrieval>();
            var employeeController = new EmployeeController(iEmployeeDataRetrieval);

            //Act
            var response = await employeeController.Get();

            //Assert
            iEmployeeDataRetrieval.Received(1).GetEmployees();
        }
    }
}
