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
    public class ExportersController : ControllerBase
    {
        private readonly TruckContext _context;

        public ExportersController(TruckContext context)
        {
            _context = context;
        }

        // GET: api/Exporters
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exporter>>> GetExporter()
        {
            return await _context.Exporter.ToListAsync();
        }

        // GET: api/Exporters/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exporter>> GetExporter(int id)
        {
            var exporter = await _context.Exporter.FindAsync(id);

            if (exporter == null)
            {
                return NotFound();
            }

            return exporter;
        }

        // PUT: api/Exporters/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExporter(int id, Exporter exporter)
        {
            if (id != exporter.Id)
            {
                return BadRequest();
            }

            _context.Entry(exporter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExporterExists(id))
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

        // POST: api/Exporters
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Exporter>> PostExporter(Exporter exporter)
        {
            _context.Exporter.Add(exporter);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExporter", new { id = exporter.Id }, exporter);
        }

        // DELETE: api/Exporters/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExporter(int id)
        {
            var exporter = await _context.Exporter.FindAsync(id);
            if (exporter == null)
            {
                return NotFound();
            }

            _context.Exporter.Remove(exporter);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ExporterExists(int id)
        {
            return _context.Exporter.Any(e => e.Id == id);
        }
    }
}
