using ApiHeros.Model;
using Microsoft.EntityFrameworkCore;

namespace ApiHeros.Data
{
    public class HeroiContext : DbContext
    {


        public HeroiContext()
        {

        }

        public HeroiContext(DbContextOptions<HeroiContext> options) : base(options)
        {

        }

        public DbSet<Heroi> Herois { get; set; }

    }
}
