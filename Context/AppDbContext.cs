using Microsoft.EntityFrameworkCore;
using vanta_multimedia_storage.Models;

namespace vanta_multimedia_storage.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        public DbSet<Multimedia> multimedias { get; set; }
    }
}
