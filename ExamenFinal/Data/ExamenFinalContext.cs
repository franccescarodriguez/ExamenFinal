using Microsoft.EntityFrameworkCore;
using ExamenFinal.Models;

namespace ExamenFinal.Data
{
    public class ExamenFinalContext : DbContext
    {
        public ExamenFinalContext(DbContextOptions<ExamenFinalContext> options)
            : base(options)
        {
        }

        public DbSet<Pago> Pagos { get; set; }
    }
}
