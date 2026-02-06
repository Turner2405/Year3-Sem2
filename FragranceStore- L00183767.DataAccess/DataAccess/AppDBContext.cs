using FragranceStore__L00183767.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace FragranceStore__L00183767.DataAccess.DataAccess
{
    public class AppDBContext : DbContext
    {
       public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
       {


       }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Concentration> Concentrations { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
