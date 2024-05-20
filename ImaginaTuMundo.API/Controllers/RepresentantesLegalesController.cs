using ImaginaTuMundo.API.Data;
using ImaginaTuMundo.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImaginaTuMundo.API.Controllers
{
    [ApiController]
    [Route("/api/RepresentantesLegalesController")]
    public class RepresentantesLegalesController : ControllerBase
    {
        private readonly DataContext _context;

        public RepresentantesLegalesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.RepresentantesLegales.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(RepresentanteLegal RepresentanteLegal)
        {
            _context.Add(RepresentanteLegal);
            await _context.SaveChangesAsync();
            return Ok(RepresentanteLegal);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var RepresentanteLegal = await _context.RepresentantesLegales.FirstOrDefaultAsync(x => x.Id == id);

            if (RepresentanteLegal == null)
            {
                return NotFound();
            }

            return Ok(RepresentanteLegal);
        }

        [HttpPut]
        public async Task<ActionResult> Put(RepresentanteLegal RepresentanteLegal)
        {
            _context.Update(RepresentanteLegal);
            await _context.SaveChangesAsync();
            return Ok(RepresentanteLegal);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.RepresentantesLegales.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
