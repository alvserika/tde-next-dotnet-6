using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using tde_api.Contas;
using tde_api.Models;

namespace tde_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestinosController : ControllerBase
    {
        private readonly DataContext _context;

        public DestinosController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Destinos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destino>>> GetDestino()
        {
          if (_context.Destino == null)
          {
              return NotFound();
          }
            return await _context.Destino.ToListAsync();
        }

        // GET: api/Destinos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Destino>> GetDestino(int id)
        {
          if (_context.Destino == null)
          {
              return NotFound();
          }
            var destino = await _context.Destino.FindAsync(id);

            if (destino == null)
            {
                return NotFound();
            }

            return destino;
        }

        // PUT: api/Destinos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestino(int id, Destino destino)
        {
            if (id != destino.Id)
            {
                return BadRequest();
            }

            _context.Entry(destino).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Destinos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Destino>> PostDestino(Destino destino)
        {
          if (_context.Destino == null)
          {
              return Problem("Entity set 'DataContext.Destino'  is null.");
          }
            _context.Destino.Add(destino);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDestino", new { id = destino.Id }, destino);
        }

        // DELETE: api/Destinos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestino(int id)
        {
            if (_context.Destino == null)
            {
                return NotFound();
            }
            var destino = await _context.Destino.FindAsync(id);
            if (destino == null)
            {
                return NotFound();
            }

            _context.Destino.Remove(destino);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinoExists(int id)
        {
            return (_context.Destino?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
