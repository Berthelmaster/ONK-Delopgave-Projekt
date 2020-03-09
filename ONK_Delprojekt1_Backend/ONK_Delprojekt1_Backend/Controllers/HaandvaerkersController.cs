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
    public class HaandvaerkersController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HaandvaerkersController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Haandvaerkers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Haandvaerker>>> GetHaandvaerkers()
        {
            return await _context.Haandvaerkers.ToListAsync();
        }

        // GET: api/Haandvaerkers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Haandvaerker>> GetHaandvaerker(int id)
        {
            var haandvaerker = await _context.Haandvaerkers.FindAsync(id);

            if (haandvaerker == null)
            {
                return NotFound();
            }

            return haandvaerker;
        }

        // PUT: api/Haandvaerkers/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHaandvaerker(int id, Haandvaerker haandvaerker)
        {
            if (id != haandvaerker.HaandvaerkerId)
            {
                return BadRequest();
            }

            _context.Entry(haandvaerker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HaandvaerkerExists(id))
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

        // POST: api/Haandvaerkers
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Haandvaerker>> PostHaandvaerker(Haandvaerker haandvaerker)
        {
            _context.Haandvaerkers.Add(haandvaerker);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHaandvaerker", new { id = haandvaerker.HaandvaerkerId }, haandvaerker);
        }

        // DELETE: api/Haandvaerkers/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Haandvaerker>> DeleteHaandvaerker(int id)
        {
            var haandvaerker = await _context.Haandvaerkers.FindAsync(id);
            if (haandvaerker == null)
            {
                return NotFound();
            }

            _context.Haandvaerkers.Remove(haandvaerker);
            await _context.SaveChangesAsync();

            return haandvaerker;
        }

        private bool HaandvaerkerExists(int id)
        {
            return _context.Haandvaerkers.Any(e => e.HaandvaerkerId == id);
        }
    }
}
