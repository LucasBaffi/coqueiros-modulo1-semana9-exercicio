
using Microsoft.EntityFrameworkCore;

namespace APISemana9.Model
{
    public class SemanaContext : DbContext
    {
        public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
        {
          
        Semana = Set<SemanaModel>();
        }
    public DbSet<SemanaModel>? Semana { get; set; }
    }

}
