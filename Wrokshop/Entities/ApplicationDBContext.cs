using Microsoft.EntityFrameworkCore;
namespace Wrokshop.Entities
{
    public class ApplicationDBContext: DbContext
    {
        public DbSet<CarWorkshopEntity> CarWorkshop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Workshop;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
