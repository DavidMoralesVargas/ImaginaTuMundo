using ImaginaTuMundo.API.Data;
using ImaginaTuMundo.Shared.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImaginaTuMundo.API.Controllers
{
    [ApiController]
    [Route("/api/AsignacionesMadreNino")]
    public class AsignacionesMadreNinoController : ControllerBase
    {
        private readonly DataContext _context;

        public AsignacionesMadreNinoController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.AsignacionesMadresNinios.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(AsignacionMadreNinio asignacionMadreNinio)
        {
            _context.Add(asignacionMadreNinio);
            await _context.SaveChangesAsync();
            return Ok(asignacionMadreNinio);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var asignacion = await _context.AsignacionesMadresNinios.FirstOrDefaultAsync(x => x.Id == id);

            if (asignacion == null)
            {
                return NotFound();
            }

            return Ok(asignacion);
        }

        [HttpPut]
        public async Task<ActionResult> Put(AsignacionMadreNinio asignacionmadrenino)
        {
            _context.Update(asignacionmadrenino);
            await _context.SaveChangesAsync();
            return Ok(asignacionmadrenino);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.AsignacionesMadresNinios.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}