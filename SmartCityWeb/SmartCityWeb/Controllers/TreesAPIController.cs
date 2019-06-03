using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartCityWeb.Data;
using SmartCityWeb.Models;

namespace SmartCityWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreesAPIController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public TreesAPIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/TreesAPI
        [HttpGet]
        public IEnumerable<Tree> GetTree()
        {
            return _context.Tree;
        }

        // GET: api/TreesAPI/5
        [HttpGet("{id}")]
        public IEnumerable<Tree> GetTree([FromRoute] int id)
        {
            var AllTrees = _context.Tree.ToList();

            List<Tree> idspecificSensors = new List<Tree>(AllTrees.Where(s => s.LocationID == id));

            return idspecificSensors;
        }

        // PUT: api/TreesAPI/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTree([FromRoute] string id, [FromBody] Tree tree)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tree.TreeID)
            {
                return BadRequest();
            }

            _context.Entry(tree).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TreeExists(id))
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

        // POST: api/TreesAPI
        [HttpPost]
        public async Task<IActionResult> PostTree([FromBody] Tree tree)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tree.Add(tree);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTree", new { id = tree.TreeID }, tree);
        }

        // DELETE: api/TreesAPI/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTree([FromRoute] string id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tree = await _context.Tree.FindAsync(id);
            if (tree == null)
            {
                return NotFound();
            }

            _context.Tree.Remove(tree);
            await _context.SaveChangesAsync();

            return Ok(tree);
        }

        private bool TreeExists(string id)
        {
            return _context.Tree.Any(e => e.TreeID == id);
        }
    }
}