using Microsoft.EntityFrameworkCore;
using WebApplication4.Core.Domain.Models;

namespace WebApplication4.Persistance.Context
{
    public class RickyAndMartyContext : DbContext
    {
        public RickyAndMartyContext(DbContextOptions<RickyAndMartyContext> options) : base(options)
        { }
           public DbSet<Episode> Episodes { get; set; }
           public DbSet<Character> Characters {  get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
