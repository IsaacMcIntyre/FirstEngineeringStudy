using NUnit.Framework;
using NSubstitute;
using System.Collections.Generic;
using FirstEngineeringStudy.DataLayer.Contexts;
using FirstEngineeringStudy.BusinessLayer;
using Microsoft.EntityFrameworkCore;
using FirstEngineeringStudy.DataLayer.DataModels;
using System.Linq;

namespace FirstEngineeringStudy.UnitTest.BusinessLayerTests
{
    [TestFixture]
    class EmployeeDataRetrievalTests
    {
        [Test]
        public void CorrectNumberOfEmployeesReturnedByBusinessLayer()
        {
            //Arrange 
            var data = new List<Employee>
            {
                new Employee
                {
                    FullName = "Jordan"
                },
                new Employee
                {
                    FullName = "Isaac"
                },
                new Employee
                {
                    FullName = "Andrew"
                }
            };

            var mockDbContext = Substitute.For<IDatabaseContext>();
            var employeeMock = Substitute.For<DbSet<Employee>, IQueryable<Employee>>();
            var employeeDataRetrieval = new EmployeeDataRetrieval(mockDbContext);
            ((IQueryable<Employee>) employeeMock).GetEnumerator().Returns(data.GetEnumerator());
            mockDbContext.Employees.Returns(employeeMock);

            //Act
            var employees = employeeDataRetrieval.GetEmployees();

            //Assert
            Assert.AreEqual(3, employees.Length);
        }
    }
}