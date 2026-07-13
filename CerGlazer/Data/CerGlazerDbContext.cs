using Microsoft.EntityFrameworkCore;
using CerGlazer.Models;

namespace CerGlazer.Data
{
    public class CerGlazerDbContext : DbContext
    {
        public CerGlazerDbContext(DbContextOptions<CerGlazerDbContext> options) : base(options) { }

        public DbSet<Glaze> Glazes { get; set; }
    }
}
