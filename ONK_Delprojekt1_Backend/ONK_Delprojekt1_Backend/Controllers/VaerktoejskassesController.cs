using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ONK_Delprojekt1_Backend.Data;
using ONK_Delprojekt1_Backend.Models;

namespace ONK_Delprojekt1_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaerktoejskassesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VaerktoejskassesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Vaerktoejskasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vaerktoejskasse>>> GetVaerktoejskasser()
        {
            return await _context.Vaerktoejskasser.ToListAsync();
        }

        // GET: api/Vaerktoejskasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vaerktoejskasse>> GetVaerktoejskasse(int id)
        {
            var vaerktoejskasse = await _context.Vaerktoejskasser.FindAsync(id);

            if (vaerktoejskasse == null)
            {
                return NotFound();
            }

            return vaerktoejskasse;
        }

        // PUT: api/Vaerktoejskasses/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVaerktoejskasse(int id, Vaerktoejskasse vaerktoejskasse)
        {
            if (id != vaerktoejskasse.VTKId)
            {
                return BadRequest();
            }

            _context.Entry(vaerktoejskasse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VaerktoejskasseExists(id))
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

        // POST: api/Vaerktoejskasses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Vaerktoejskasse>> PostVaerktoejskasse(Vaerktoejskasse vaerktoejskasse)
        {
            _context.Vaerktoejskasser.Add(vaerktoejskasse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVaerktoejskasse", new { id = vaerktoejskasse.VTKId }, vaerktoejskasse);
        }

        // DELETE: api/Vaerktoejskasses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vaerktoejskasse>> DeleteVaerktoejskasse(int id)
        {
            var vaerktoejskasse = await _context.Vaerktoejskasser.FindAsync(id);
            if (vaerktoejskasse == null)
            {
                return NotFound();
            }

            _context.Vaerktoejskasser.Remove(vaerktoejskasse);
            await _context.SaveChangesAsync();

            return vaerktoejskasse;
        }

        private bool VaerktoejskasseExists(int id)
        {
            return _context.Vaerktoejskasser.Any(e => e.VTKId == id);
        }
    }
}
