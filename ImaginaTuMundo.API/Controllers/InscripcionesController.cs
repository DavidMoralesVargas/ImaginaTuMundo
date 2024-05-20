using ImaginaTuMundo.API.Data;
using ImaginaTuMundo.Shared.Entidades;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ImaginaTuMundo.API.Controllers
{

    [ApiController]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Route("/api/InscripcionesController")]
    public class InscripcionesController : ControllerBase
    {
        private readonly DataContext _context;

        public InscripcionesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Inscripciones.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Inscripcion Inscripcion)
        {
            _context.Add(Inscripcion);
            await _context.SaveChangesAsync();
            return Ok(Inscripcion);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var Inscripcion = await _context.Inscripciones.FirstOrDefaultAsync(x => x.Id == id);

            if (Inscripcion == null)
            {
                return NotFound();
            }

            return Ok(Inscripcion);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Inscripcion Inscripcion)
        {
            _context.Update(Inscripcion);
            await _context.SaveChangesAsync();
            return Ok(Inscripcion);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Inscripciones.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
