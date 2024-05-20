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
    [Route("/api/Asociaciones")]
    public class AsociacionesController : ControllerBase
    {
        private readonly DataContext _context;

        public AsociacionesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Asociaciones.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(Asociacion asociacion)
        {
            _context.Add(asociacion);
            await _context.SaveChangesAsync();
            return Ok(asociacion);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var asociocion = await _context.Asociaciones.FirstOrDefaultAsync(x => x.Id == id);

            if (asociocion == null)
            {
                return NotFound();
            }

            return Ok(asociocion);
        }

        [HttpPut]
        public async Task<ActionResult> Put(Asociacion asociacion)
        {
            _context.Update(asociacion);
            await _context.SaveChangesAsync();
            return Ok(asociacion);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.Asociaciones.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
