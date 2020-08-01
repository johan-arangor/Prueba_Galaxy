using Microsoft.EntityFrameworkCore;
using Prueba_Galaxy.Controllers.Models;
using Prueba_Galaxy.Models;


namespace Prueba_Galaxy.Controllers.Data
{
    public class ContratoContexto : DbContext
    {
        public ContratoContexto(DbContextOptions<ContratoContexto> options):base(options)
        {
        }
        //crear el dbset
        public DbSet<Contrato> contratosItems { get; set; }
        public DbSet<Trabajador> trabajadorItems { get; set; }
        public DbSet<Entidad> entidadItems { get; set; }
    }
}
