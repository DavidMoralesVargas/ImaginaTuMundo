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
    [Route("/api/EvidenciasController")]
    public class EvidenciasController : ControllerBase
    {
        private readonly DataContext _context;

        public EvidenciasController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Evidencias.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Evidencia evidencia)
        {
            _context.Add(evidencia);
            await _context.SaveChangesAsync();
            return Ok(evidencia);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var evidencia = await _context.Evidencias.FirstOrDefaultAsync(x => x.Id == id);

            if (evidencia == null)
            {
                return NotFound();
            }

            return Ok(evidencia);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Evidencia evidencia)
        {
            _context.Update(evidencia);
            await _context.SaveChangesAsync();
            return Ok(evidencia);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Evidencias.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
