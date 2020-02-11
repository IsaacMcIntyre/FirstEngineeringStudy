using FirstEngineeringStudy.DataLayer.DataModels;
using Microsoft.EntityFrameworkCore;

namespace FirstEngineeringStudy.DataLayer.Contexts
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options) 
            : base(options)
        { }
        public DbSet<Employee> Employees { get; set; }
    }

    public interface IDatabaseContext
    {
        DbSet<Employee> Employees { get; set; }
    }
}
