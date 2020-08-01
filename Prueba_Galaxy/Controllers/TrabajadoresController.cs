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
    public class TrabajadoresController : ControllerBase
    {
        private readonly ContratoContexto _trabajadorContext;

        public TrabajadoresController(ContratoContexto trabajadorContext)
        {
            _trabajadorContext = trabajadorContext;
        }
        // Peticion tipo GEt api/trabajadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Trabajador>>> GetTrabajadorItems()
        {
            return await _trabajadorContext.trabajadorItems.ToListAsync();
        }

        //petcion tipo GEt a un solo registro api/trabajador
        [HttpGet("{id}")]
        public async Task<ActionResult<Trabajador>> GetTrabajadorItem(int id)
        {
            var trabajadorItem = await _trabajadorContext.trabajadorItems.FindAsync(id);

            if(trabajadorItem == null)
            {
                return NotFound();
            }

            return trabajadorItem;
        }
    }
}
