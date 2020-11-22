

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace ASdatabase
{
    public class ASDbContextDatabase : IdentityDbContext
    {
        public DbSet<Zarzadzenie> Zarzadzenia { get; set; }
        public DbSet<Ogloszenie> Ogloszenia { get; set; }
        public DbSet<Instrukcja> Instrukcja{ get; set; }
        public DbSet<Color> Color { get; set; }
        public DbSet<SizeFont> SizeFont { get; set; }
        public DbSet<ActualizationContent> ActualizationContent { get; set; }
        public ASDbContextDatabase(DbContextOptions optionsBuilder) : base(optionsBuilder)
        {

        }
    }
}
