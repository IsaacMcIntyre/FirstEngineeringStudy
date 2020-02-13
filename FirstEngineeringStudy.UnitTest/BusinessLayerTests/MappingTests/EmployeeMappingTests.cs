using System;
using FirstEngineeringStudy.BusinessLayer.Mapping;
using FirstEngineeringStudy.DataLayer.DataModels;
using FirstEngineeringStudy.ViewModels.Employee;
using NUnit.Framework;

namespace FirstEngineeringStudy.UnitTest.BusinessLayerTests.MappingTests
{
    [TestFixture]
    public class EmployeeMappingTests
    {
        [Test]
        public void MapsEmployeeDataModelToEmployeeRetrievalViewModelWhichIsNotNull()
        {
            //Arrange
            var employeeDataModel = new Employee();
            var employeeMapping = new EmployeeMapping();

            //Act
            var employeeResponseVm = employeeMapping.DataModelToRetrievalViewModel(employeeDataModel);

            //Assert
            Assert.IsNotNull(employeeResponseVm);
        }

        [Test]
        public void MapsEmployeeDataModelToEmployeeRetrievalViewModelHasAllRequiredData()
        {
            //Arrange


            //Act


            //Assert

        }



        [Test]
        public void EmployeeDataModelIsNullThenArgumentExceptionIsThrown()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}