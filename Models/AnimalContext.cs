using Microsoft.EntityFrameworkCore;

namespace CrudAsp.Models
{
    public class AnimaisContext : DbContext
    {
        public AnimaisContext(DbContextOptions<AnimaisContext> options) : base(options)
        {
        }
        public DbSet<Animal> Animais { get; set; }
    }
}
