using FirstEngineeringStudy.DataLayer.Contexts;
using FirstEngineeringStudy.DataLayer.DataModels;
using System.Collections.Generic;

namespace FirstEngineeringStudy.IntegrationTests.Utilities
{
    public static class Utilities
    {
        public static void InitializeDbForTests(DatabaseContext db)
        {
            var employeeSeedData = GetSeedingEmployees();
            db.Employees.AddRange(employeeSeedData);
            db.SaveChanges();
        }
        public static List<Employee> GetSeedingEmployees()
        {
            return new List<Employee> {
                    new Employee {
                        EmployeeId = 1,
                        FullName = "Jordan S",
                        EmployeeNumber = 123,
                        ClubId = 1
                    },
                    new Employee {
                        EmployeeId = 2,
                        FullName = "Isaac",
                        EmployeeNumber = 123,
                        ClubId = 1
                    }
                };
        }
    }
}