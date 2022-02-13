using Microsoft.EntityFrameworkCore;

namespace COMP2139_KRN_GENIUS.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; } //collection of objects created from Products entity
        public DbSet<Technician> Technicians { get; set; }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData
            (
                new Product { ProductId = 1, Name = "Seunghun Yim", Code = "FXDS234", YearlyPrice = 3.34, Date = DateTime.Now },
                new Product { ProductId = 2, Name = "Yoonhee Kim", Code = "HER132", YearlyPrice = 5.23, Date = DateTime.Now },
                new Product { ProductId = 3, Name = "JooYoung Song", Code = "HISD152", YearlyPrice = 10.23, Date = DateTime.Now }
            );

            modelBuilder.Entity<Technician>().HasData
            (
                new Technician { TechnicianId = 1, Name = "Seunghun Yim", Email = "fjeidjwidkd@gmail.com", Phone = "415-222-2223" },
                new Technician { TechnicianId = 2, Name = "Yoonhee Kim", Email = "salrfku@gmail.com", Phone = "423-523-1233" },
                new Technician { TechnicianId = 3, Name = "JooYoung Song", Email = "yimsh4507@gmail.com", Phone = "123-123-1234" }
            );
        }
    }
}
