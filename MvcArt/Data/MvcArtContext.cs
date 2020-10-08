using Microsoft.EntityFrameworkCore;
using MvcArt.Models;

namespace MvcArt.Data
{
    public class MvcArtContext : DbContext
    {
        public MvcArtContext (DbContextOptions<MvcArtContext> options)
            : base(options)
        { 
        }

        public DbSet<Art> Art { get; set; }
    }
}
