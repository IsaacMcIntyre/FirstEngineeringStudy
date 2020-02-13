using System;
using FirstEngineeringStudy.BusinessLayer.Mapping;
using FirstEngineeringStudy.DataLayer.DataModels;
using NSubstitute.Core;
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
        public void MapsEmployeeDataModelToEmployeeRetrievalViewModelHasAllRequiredDataMatching()
        {
            //Arrange
            var employeeDataModel = new Employee(1, "email@email.email", 1, "John Doe", new DateTime(), new DateTime(), 500000, 1, 1);
            var employeeMapping = new EmployeeMapping();

            //Act
            var employeeResponseVm = employeeMapping.DataModelToRetrievalViewModel(employeeDataModel);

            //Assert
            Assert.AreEqual(employeeDataModel.EmployeeId, employeeResponseVm.EmployeeId);
            Assert.AreEqual(employeeDataModel.Email, employeeResponseVm.Email);
            Assert.AreEqual(employeeDataModel.EmployeeNumber, employeeResponseVm.EmployeeNumber);
            Assert.AreEqual(employeeDataModel.FullName, employeeResponseVm.FullName);
            Assert.AreEqual(employeeDataModel.DOB, employeeResponseVm.DOB);
            Assert.AreEqual(employeeDataModel.StartDate, employeeResponseVm.StartDate);
            Assert.AreEqual(employeeDataModel.Salary, employeeResponseVm.Salary);
        }

        [Test]
        public void EmployeeDataModelIsNullThenArgumentExceptionIsThrown()
        {
            //Arrange
            Employee employeeDataModel = null;
            var employeeMapping = new EmployeeMapping();

            //Assert
            Assert.Throws<ArgumentException>(() => employeeMapping.DataModelToRetrievalViewModel(employeeDataModel));
        }

        [Test]
        public void MapsEmployeeDataModelArrayToEmployeeRetrievalViewModelArrayWhichIsNotEmpty()
        {
            //Arrange
            Employee[] employeeDataModelArray = {new Employee(), new Employee()};
            var employeeMapping = new EmployeeMapping();

            //Act
            var employeeResponseVm = employeeMapping.DataModelToRetrievalViewModel(employeeDataModelArray);

            //Assert
            Assert.IsNotEmpty(employeeResponseVm);
        }

        [Test]
        public void MapsTwoEmployeeDataModelsInArrayToEmployeeRetrievalViewModelArrayWhichHasTwoElements()
        {
            //Arrange
            Employee[] employeeDataModelArray = { new Employee(), new Employee() };
            var employeeMapping = new EmployeeMapping();

            //Act
            var employeeResponseVm = employeeMapping.DataModelToRetrievalViewModel(employeeDataModelArray);

            //Assert
            Assert.AreEqual(2, employeeResponseVm.Length);
        }


    }
}