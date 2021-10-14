using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Test.Data;
using API_Test.Models;

namespace API_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlotsController : ControllerBase
    {
        private readonly TruckContext _context;

        public SlotsController(TruckContext context)
        {
            _context = context;
        }

        // GET: api/Slots
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Slots>>> GetSlots()
        {
            return await _context.Slots.ToListAsync();
        }

        // GET: api/Slots/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Slots>> GetSlots(int id)
        {
            var slots = await _context.Slots.FindAsync(id);

            if (slots == null)
            {
                return NotFound();
            }

            return slots;
        }

        // PUT: api/Slots/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSlots(int id, Slots slots)
        {
            if (id != slots.Id)
            {
                return BadRequest();
            }

            _context.Entry(slots).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SlotsExists(id))
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

        // POST: api/Slots
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Slots>> PostSlots(Slots slots)
        {
            _context.Slots.Add(slots);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSlots", new { id = slots.Id }, slots);
        }

        // DELETE: api/Slots/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSlots(int id)
        {
            var slots = await _context.Slots.FindAsync(id);
            if (slots == null)
            {
                return NotFound();
            }

            _context.Slots.Remove(slots);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SlotsExists(int id)
        {
            return _context.Slots.Any(e => e.Id == id);
        }
    }
}
