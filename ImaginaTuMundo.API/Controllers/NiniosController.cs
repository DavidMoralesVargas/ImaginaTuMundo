using ImaginaTuMundo.API.Data;
using ImaginaTuMundo.Shared.Entidades;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImaginaTuMundo.API.Controllers
{
    [ApiController]
    [Route("/api/NiniosController")]
    public class NiniosController : ControllerBase
    {
        private readonly DataContext _context;

        public NiniosController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Ninios.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Ninios Ninios)
        {
            _context.Add(Ninios);
            await _context.SaveChangesAsync();
            return Ok(Ninios);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var Ninios = await _context.Ninios.FirstOrDefaultAsync(x => x.Id == id);

            if (Ninios == null)
            {
                return NotFound();
            }

            return Ok(Ninios);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Ninios Ninios)
        {
            _context.Update(Ninios);
            await _context.SaveChangesAsync();
            return Ok(Ninios);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Ninios.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
