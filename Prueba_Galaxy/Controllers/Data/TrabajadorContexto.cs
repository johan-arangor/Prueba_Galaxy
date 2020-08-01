using Microsoft.EntityFrameworkCore;
using Prueba_Galaxy.Models;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace Prueba_Galaxy.Controllers.Data
{
    public class TrabajadorContexto : DbContext
    {
        public TrabajadorContexto(DbContextOptions<TrabajadorContexto> options):base(options)
        {
        }
        //crear el dbset
        public DbSet<Trabajador> trabajadoresItems { get; set; }
    }
}
