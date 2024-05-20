using ImaginaTuMundo.API.Data;
using ImaginaTuMundo.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImaginaTuMundo.API.Controllers
{

    [ApiController]
    [Route("/api/SeguimientosNiniosController")]
    public class SeguimientosNiniosController : ControllerBase
    {
        private readonly DataContext _context;

        public SeguimientosNiniosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.SeguimientosNinios.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(SeguimientoNinios SeguimientoNinios)
        {
            _context.Add(SeguimientoNinios);
            await _context.SaveChangesAsync();
            return Ok(SeguimientoNinios);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var SeguimientoNinios = await _context.SeguimientosNinios.FirstOrDefaultAsync(x => x.Id == id);

            if (SeguimientoNinios == null)
            {
                return NotFound();
            }

            return Ok(SeguimientoNinios);
        }

        [HttpPut]
        public async Task<ActionResult> Put(SeguimientoNinios SeguimientoNinios)
        {
            _context.Update(SeguimientoNinios);
            await _context.SaveChangesAsync();
            return Ok(SeguimientoNinios);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.SeguimientosNinios.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
