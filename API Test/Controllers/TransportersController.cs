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
    public class TransportersController : ControllerBase
    {
        private readonly TruckContext _context;

        public TransportersController(TruckContext context)
        {
            _context = context;
        }

        // GET: api/Transporters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transporter>>> GetTransporter()
        {
            return await _context.Transporter.ToListAsync();
        }

        // GET: api/Transporters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Transporter>> GetTransporter(int id)
        {
            var transporter = await _context.Transporter.FindAsync(id);

            if (transporter == null)
            {
                return NotFound();
            }

            return transporter;
        }

        // PUT: api/Transporters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransporter(int id, Transporter transporter)
        {
            if (id != transporter.Id)
            {
                return BadRequest();
            }

            _context.Entry(transporter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransporterExists(id))
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

        // POST: api/Transporters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Transporter>> PostTransporter(Transporter transporter)
        {
            _context.Transporter.Add(transporter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTransporter", new { id = transporter.Id }, transporter);
        }

        // DELETE: api/Transporters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTransporter(int id)
        {
            var transporter = await _context.Transporter.FindAsync(id);
            if (transporter == null)
            {
                return NotFound();
            }

            _context.Transporter.Remove(transporter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TransporterExists(int id)
        {
            return _context.Transporter.Any(e => e.Id == id);
        }
    }
}
