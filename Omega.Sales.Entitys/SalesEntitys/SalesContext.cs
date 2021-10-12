using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Omega.Sales.Entitys
{
    public class SalesContext : DbContext
    {
        public  DbSet<Role> Roles { get; set; }
        public  DbSet<User> Users { get; set; }
        public SalesContext()

        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=m-dts01; Database = test; Trusted_Connection=True;");
        }
    }
}