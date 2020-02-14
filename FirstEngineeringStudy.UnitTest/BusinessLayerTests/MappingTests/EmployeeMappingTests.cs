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
            var employeeDataModel = new Employee
            {
                EmployeeId = 1, Email = "email@email.email", EmployeeNumber = 1, FullName = "John Doe", 
                DOB = new DateTime(), StartDate = new DateTime(), Salary = 500000, ClubId = 1, LicenseId = 1
            };
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
            var employeeDataModel = new Employee
            {
                EmployeeId = 1, Email = "email@email.email" , EmployeeNumber = 1, FullName = "John Doe", 
                DOB = new DateTime(), StartDate = new DateTime(), Salary = 500000, ClubId = 1, LicenseId = 1
            };
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
            Employee[] employeeDataModelArray =
            {
                new Employee
                {
                    EmployeeId = 1, Email = "email@email.email" , EmployeeNumber = 1, FullName = "John Doe", 
                    DOB = new DateTime(), StartDate = new DateTime(), Salary = 500000, ClubId = 1, LicenseId = 1
                },
                new Employee
                {
                    EmployeeId = 1, Email = "email@email.email", EmployeeNumber = 1, FullName = "John Doe", 
                    DOB = new DateTime(), StartDate = new DateTime(), Salary = 500000, ClubId = 1, LicenseId = 1
                }
            };
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
            Employee[] employeeDataModelArray =
            {
                new Employee
                {
                    EmployeeId = 1, Email = "email@email.email" , EmployeeNumber = 1, FullName = "John Doe", 
                    DOB = new DateTime(), StartDate = new DateTime(), Salary = 500000, ClubId = 1, LicenseId = 1
                },
                new Employee
                {
                    EmployeeId = 1, Email = "email@email.email", EmployeeNumber = 1, FullName = "John Doe", 
                    DOB = new DateTime(), StartDate = new DateTime(), Salary = 500000, ClubId = 1, LicenseId = 1
                }
            };
            var employeeMapping = new EmployeeMapping();

            //Act
            var employeeResponseVm = employeeMapping.DataModelToRetrievalViewModel(employeeDataModelArray);

            //Assert
            Assert.AreEqual(2, employeeResponseVm.Length);
        }

        [Test]
        public void MapsEmptyEmployeeDataModelArrayToEmployeeRetrievalViewModelArray()
        {
            //Arrange
            Employee[] employeeDataModelArray = { };
            var employeeMapping = new EmployeeMapping();

            //Act
            var employeeResponseVmArray = employeeMapping.DataModelToRetrievalViewModel(employeeDataModelArray);

            //Assert
            Assert.IsInstanceOf(typeof(EmployeeResponseVm[]), employeeResponseVmArray);
        }
    }
}