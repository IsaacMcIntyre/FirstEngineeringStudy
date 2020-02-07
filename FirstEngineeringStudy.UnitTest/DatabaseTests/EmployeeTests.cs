using FirstEngineeringStudy.DataLayer.Contexts;
using FirstEngineeringStudy.DataLayer.DataModels;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
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

        private DbContextOptions<DatabaseContext> GetDbContextOptions(SqliteConnection connection)
        {
            var options = new DbContextOptionsBuilder<DatabaseContext>()
                    .UseSqlite(connection)
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
            var connection = new SqliteConnection("DataSource=:memory:");
            try
            {
                connection.Open();
                var options = GetDbContextOptions(connection);
                using(var context = new DatabaseContext(options))
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
            catch (System.Exception e)
            {
                Assert.Fail("Connection to DB likely failed");
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
