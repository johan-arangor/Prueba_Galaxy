using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba_Galaxy.Controllers.Data;
using Prueba_Galaxy.Controllers.Models;

namespace Prueba_Galaxy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntidadesController : ControllerBase
    {
        private readonly ContratoContexto _entidadContext;

        public EntidadesController(ContratoContexto entidadContext)
        {
            _entidadContext = entidadContext;
        }
        // Peticion tipo GEt api/entidades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entidad>>> GetEntidadItems()
        {
            return await _entidadContext.entidadItems.ToListAsync();
        }

        //petcion tipo GEt a un solo registro api/entidades
        [HttpGet("{id}")]
        public async Task<ActionResult<Entidad>> GetEntidadItem(int id)
        {
            var entidadItem = await _entidadContext.entidadItems.FindAsync(id);

            if (entidadItem == null)
            {
                return NotFound();
            }

            return entidadItem;
        }

        [HttpPost]
        public async Task<ActionResult<Entidad>> PostEntidadItem(Entidad item)
        {
            _entidadContext.entidadItems.Add(item);
            await _entidadContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEntidadItem), new { id = item.Id }, item);
        }
    }
}