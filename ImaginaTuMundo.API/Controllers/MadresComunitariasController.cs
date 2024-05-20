using ImaginaTuMundo.API.Data;
using ImaginaTuMundo.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImaginaTuMundo.API.Controllers
{

    [ApiController]
    [Route("/api/MadresComunitariasController")]
    public class MadresComunitariasController : ControllerBase
    {
        private readonly DataContext _context;

        public MadresComunitariasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.MadresComunitarias.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(MadreComunitaria MadreComunitaria)
        {
            _context.Add(MadreComunitaria);
            await _context.SaveChangesAsync();
            return Ok(MadreComunitaria);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var MadreComunitaria = await _context.MadresComunitarias.FirstOrDefaultAsync(x => x.Id == id);

            if (MadreComunitaria == null)
            {
                return NotFound();
            }

            return Ok(MadreComunitaria);
        }

        [HttpPut]
        public async Task<ActionResult> Put(MadreComunitaria MadreComunitaria)
        {
            _context.Update(MadreComunitaria);
            await _context.SaveChangesAsync();
            return Ok(MadreComunitaria);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.MadresComunitarias.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
