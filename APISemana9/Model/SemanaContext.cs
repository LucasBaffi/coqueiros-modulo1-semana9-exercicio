
using Microsoft.EntityFrameworkCore;

namespace APISemana9.Model
{
    public class SemanaContext : DbContext
    {
       public SemanaContext(DbContextOptions<SemanaContext> options) : base(options)
        {   
            Semana.Add(new Semana);
        }

        public DbSet<SemanaModel> Semana { get; set; }
    }
}