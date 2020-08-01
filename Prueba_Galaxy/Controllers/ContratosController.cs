using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Prueba_Galaxy.Controllers.Data;
using Prueba_Galaxy.Models;

namespace Prueba_Galaxy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratosController : ControllerBase
    {
        private readonly ContratoContexto _contratContext;

        public ContratosController(ContratoContexto contratContext)
        {
            _contratContext = contratContext;
        }
        // Peticion tipo GEt api/contratos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contrato>>> GetContratoItems()
        {
            return await _contratContext.contratosItems.ToListAsync();
        }

        //petcion tipo GEt a un solo registro api/contratos
        [HttpGet("{id}")]
        public async Task<ActionResult<Contrato>> GetContratoItem(int id)
        {
            var contratoItem = await _contratContext.contratosItems.FindAsync(id);

            if(contratoItem == null)
            {
                return NotFound();
            }

            return contratoItem;
        }
        //petcion tipo POST api/contratos
        [HttpPost]
        public async Task<ActionResult<Contrato>> PostContratoItem(Contrato item)
        {
            _contratContext.contratosItems.Add(item);
            await _contratContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetContratoItem), new { id = item.Id }, item);
        }
    }
}
