using Microsoft.EntityFrameworkCore;

namespace Omega.Sales.Entitys
{
    public class TruckContext : DbContext
    {
        public DbSet<tbx_N_Part> tbx_N_Part { get; set; }

        public DbSet<tbc_N_Part_Nomenclature_Specifications> tbc_N_Part_Nomenclature_Specifications { get; set; }

        public TruckContext(DbContextOptions<TruckContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}