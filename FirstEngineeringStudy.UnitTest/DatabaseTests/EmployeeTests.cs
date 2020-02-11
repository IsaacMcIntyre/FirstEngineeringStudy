using FirstEngineeringStudy.DataLayer.Contexts;
using FirstEngineeringStudy.DataLayer.DataModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FirstEngineeringStudy.UnitTest.DatabaseTests
{
    [TestFixture]
    public class EmployeeTests
    {

        private DbContextOptions<DatabaseContext> GetDbContextOptions(string dbName)
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                    .UseInMemoryDatabase(databaseName: dbName)
                    .Options;

            using (var context = new DatabaseContext(options))
            {
                context.Database.EnsureCreated();
            }

            return options;
        }

        [Test]
        public void GetAllEmployeesFromDatabase()
        {
            //Arrange
            var options = GetDbContextOptions("GetAll");
            using (var context = new DatabaseContext(options))
            {
                context.Employees.AddRange(new List<Employee>()
                {
                    new Employee { FullName = "Jordan" },
                    new Employee { FullName = "Andrew" },
                    new Employee { FullName = "Isaac" }
                });
                context.SaveChanges();
            }

            //Act
            int employeeCount;
            using (var context = new DatabaseContext(options))
            {
                employeeCount = context.Employees.Count();
            }

            //Assert
            Assert.AreEqual(3, employeeCount);

        }
    }
}
