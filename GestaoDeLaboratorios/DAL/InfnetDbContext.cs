using Microsoft.EntityFrameworkCore;
using GestaoDeLaboratorios.Models;

namespace GestaoDeLaboratorios.DAL
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<GestaoDeLaboratorios.Models.Computador> Computador { get; set; } = default!;
    }
}