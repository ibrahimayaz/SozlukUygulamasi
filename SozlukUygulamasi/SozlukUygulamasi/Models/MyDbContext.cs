using Microsoft.EntityFrameworkCore;

namespace SozlukUygulamasi.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> o) : base(o)
        {

        }

        public DbSet<Sozluk> Sozluk { get; set; }

        
    }
}
