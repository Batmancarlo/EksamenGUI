using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Clauses;
using SmartCityWeb.Data;
using SmartCityWeb.Models;

namespace SmartCityWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SensorsAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public SensorsAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/SensorsAPI
        [HttpGet]
        public IEnumerable<Sensor> GetSensor()
        {
            return _context.Sensor;
        }

        // GET: api/SensorsAPI/5
        [HttpGet("{id}")]
        public  IEnumerable<Sensor> GetSensor([FromRoute] int id)
        {

            var AllSensors = _context.Sensor.ToList();

            List<Sensor> idspecificSensors = new List<Sensor>(AllSensors.Where(s=>s.LocationID == id));
            
            return idspecificSensors;
        }

        // PUT: api/SensorsAPI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSensor([FromRoute] string id, [FromBody] Sensor sensor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != sensor.SensorID)
            {
                return BadRequest();
            }

            _context.Entry(sensor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SensorExists(id))
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

        // POST: api/SensorsAPI
        [HttpPost]
        public async Task<IActionResult> PostSensor([FromBody] Sensor sensor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Sensor.Add(sensor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSensor", new { id = sensor.SensorID }, sensor);
        }

        // DELETE: api/SensorsAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSensor([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var sensor = await _context.Sensor.FindAsync(id);
            if (sensor == null)
            {
                return NotFound();
            }

            _context.Sensor.Remove(sensor);
            await _context.SaveChangesAsync();

            return Ok(sensor);
        }

        private bool SensorExists(string id)
        {
            return _context.Sensor.Any(e => e.SensorID == id);
        }
    }
}