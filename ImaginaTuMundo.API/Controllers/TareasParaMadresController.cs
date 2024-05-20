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
    [Route("/api/TareasParaMadresController")]
    public class TareasParaMadresController : ControllerBase
    {
        private readonly DataContext _context;

        public TareasParaMadresController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.TareasParaMadres.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(TareaParaMadre TareaParaMadre)
        {
            _context.Add(TareaParaMadre);
            await _context.SaveChangesAsync();
            return Ok(TareaParaMadre);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var TareaParaMadre = await _context.TareasParaMadres.FirstOrDefaultAsync(x => x.Id == id);

            if (TareaParaMadre == null)
            {
                return NotFound();
            }

            return Ok(TareaParaMadre);
        }

        [HttpPut]
        public async Task<ActionResult> Put(TareaParaMadre TareaParaMadre)
        {
            _context.Update(TareaParaMadre);
            await _context.SaveChangesAsync();
            return Ok(TareaParaMadre);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.TareasParaMadres.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
