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
    [Route("/api/ICBFs")]
    public class ICBFsController : ControllerBase
    {
        private readonly DataContext _context;

        public ICBFsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.ICBFs.ToListAsync());
        }

        [HttpPost]
        public async Task<ActionResult> Post(ICBF ICBF)
        {
            _context.Add(ICBF);
            await _context.SaveChangesAsync();
            return Ok(ICBF);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var ICBF = await _context.ICBFs.FirstOrDefaultAsync(x => x.Id == id);

            if (ICBF == null)
            {
                return NotFound();
            }

            return Ok(ICBF);
        }

        [HttpPut]
        public async Task<ActionResult> Put(ICBF ICBF)
        {
            _context.Update(ICBF);
            await _context.SaveChangesAsync();
            return Ok(ICBF);
        }


        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var FilasAfectadas = await _context.ICBFs.Where(x => x.Id == id).ExecuteDeleteAsync();

            if (FilasAfectadas == 0)
            {
                return NotFound();
            }

            return NoContent();
        }

    }
}
