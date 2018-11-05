using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BotanasDIVAL.Models;

namespace BotanasDIVAL.Controllers
{
    public class AlmacenController : Controller
    {
        private readonly db_divalContext _context;

        public AlmacenController(db_divalContext context)
        {
            _context = context;
        }

        // GET: Almacen
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.Almacen.Include(a => a.IdIngredienteNavigation).Include(a => a.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: Almacen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen
                .Include(a => a.IdIngredienteNavigation)
                .Include(a => a.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdAlmacen == id);
            if (almacen == null)
            {
                return NotFound();
            }

            return View(almacen);
        }

        // GET: Almacen/Create
        public IActionResult Create()
        {
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente");
            ViewData["Status"] = new SelectList(_context.Status, "status", "DescripcionStatus");
            return View();
        }

        // POST: Almacen/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAlmacen,IdIngrediente,Cantidad,FechaCaducidad,Status,Observaciones")] Almacen almacen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(almacen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente", almacen.IdIngrediente);
            ViewData["Status"] = new SelectList(_context.Status, "status", "DescripcionStatus", almacen.Status);
            return View(almacen);
        }

        // GET: Almacen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen.FindAsync(id);
            if (almacen == null)
            {
                return NotFound();
            }
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente", almacen.IdIngrediente);
            ViewData["Status"] = new SelectList(_context.Status, "status", "DescripcionStatus", almacen.Status);
            return View(almacen);
        }

        // POST: Almacen/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAlmacen,IdIngrediente,Cantidad,FechaCaducidad,Status,Observaciones")] Almacen almacen)
        {
            if (id != almacen.IdAlmacen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(almacen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlmacenExists(almacen.IdAlmacen))
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
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente", almacen.IdIngrediente);
            ViewData["Status"] = new SelectList(_context.Status, "status", "DescripcionStatus", almacen.Status);
            return View(almacen);
        }

        // GET: Almacen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var almacen = await _context.Almacen
                .Include(a => a.IdIngredienteNavigation)
                .Include(a => a.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdAlmacen == id);
            if (almacen == null)
            {
                return NotFound();
            }

            return View(almacen);
        }

        // POST: Almacen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var almacen = await _context.Almacen.FindAsync(id);
            _context.Almacen.Remove(almacen);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlmacenExists(int id)
        {
            return _context.Almacen.Any(e => e.IdAlmacen == id);
        }
    }
}
