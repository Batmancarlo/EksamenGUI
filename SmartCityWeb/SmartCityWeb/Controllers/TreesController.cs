using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmartCityWeb.Data;
using SmartCityWeb.Models;

namespace SmartCityWeb.Controllers
{
    public class TreesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TreesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Trees
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Tree.Include(t => t.Location);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Trees/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tree = await _context.Tree
                .Include(t => t.Location)
                .FirstOrDefaultAsync(m => m.TreeID == id);
            if (tree == null)
            {
                return NotFound();
            }

            return View(tree);
        }

        // GET: Trees/Create
        public IActionResult Create(int i)
        {
            ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationID");
            return View();
        }

        // POST: Trees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TreeID,TreeSort,NumberOfTrees,LocationID")] Tree tree)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tree);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Home");
            }
            ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationID", tree.LocationID);
            return RedirectToAction("Index", "Home");
        }

        // GET: Trees/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tree = await _context.Tree.FindAsync(id);
            if (tree == null)
            {
                return NotFound();
            }
            ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationID", tree.LocationID);
            return View(tree);
        }

        // POST: Trees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TreeID,TreeSort,NumberOfTrees,LocationID")] Tree tree)
        {
            if (id != tree.TreeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tree);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TreeExists(tree.TreeID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["LocationID"] = new SelectList(_context.Location, "LocationID", "LocationID", tree.LocationID);
            return View(tree);
        }

        // GET: Trees/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tree = await _context.Tree
                .Include(t => t.Location)
                .FirstOrDefaultAsync(m => m.TreeID == id);
            if (tree == null)
            {
                return NotFound();
            }

            return View(tree);
        }

        // POST: Trees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tree = await _context.Tree.FindAsync(id);
            _context.Tree.Remove(tree);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TreeExists(string id)
        {
            return _context.Tree.Any(e => e.TreeID == id);
        }
    }
}
