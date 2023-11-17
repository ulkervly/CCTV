using CCTV_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CCTV_MVC
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) 
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<SecurityService> SecurityServices { get; set; }

    }
}
