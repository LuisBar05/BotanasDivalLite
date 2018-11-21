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
    public class ListasIngredientesController : Controller
    {
        private readonly db_divalContext _context;

        public ListasIngredientesController(db_divalContext context)
        {
            _context = context;
        }

        // GET: ListasIngredientes
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.ListasIngredientes.Include(l => l.IdIngredienteNavigation).Include(l => l.IdRecetaNavigation).Include(l => l.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: ListasIngredientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaIngredientes = await _context.ListasIngredientes
                .Include(l => l.IdIngredienteNavigation)
                .Include(l => l.IdRecetaNavigation)
                .Include(l => l.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdListasIngred == id);
            if (listaIngredientes == null)
            {
                return NotFound();
            }

            return View(listaIngredientes);
        }

        // GET: ListasIngredientes/Create
        public IActionResult Create()
        {
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente");
            ViewData["IdReceta"] = new SelectList(_context.Recetas, "IdReceta", "Descripcion");
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: ListasIngredientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdReceta,IdIngrediente,Cantidad,Status,Observaciones")] ListasIngredientes listaIngredientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(listaIngredientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente", listaIngredientes.IdIngrediente);
            ViewData["IdReceta"] = new SelectList(_context.Recetas, "IdReceta", "Descripcion", listaIngredientes.IdReceta);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", listaIngredientes.Status);
            return View(listaIngredientes);
        }

        // GET: ListasIngredientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaIngredientes = await _context.ListasIngredientes.FindAsync(id);
            _context.Entry(listaIngredientes).State = EntityState.Detached;
            if (listaIngredientes == null)
            {
                return NotFound();
            }
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente", listaIngredientes.IdIngrediente);
            ViewData["IdReceta"] = new SelectList(_context.Recetas, "IdReceta", "Descripcion", listaIngredientes.IdReceta);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", listaIngredientes.Status);
            return View(listaIngredientes);
        }

        // POST: ListasIngredientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdListasIngred,IdReceta,IdIngrediente,Cantidad,Status,Observaciones")] ListasIngredientes listaIngredientes)
        {
            if (id != listaIngredientes.IdListasIngred)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listaIngredientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListasIngredientesExists(listaIngredientes.IdListasIngred))
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
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente", listaIngredientes.IdIngrediente);
            ViewData["IdReceta"] = new SelectList(_context.Recetas, "IdReceta", "Descripcion", listaIngredientes.IdReceta);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", listaIngredientes.Status);
            return View(listaIngredientes);
        }

        // GET: ListasIngredientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaIngredientes = await _context.ListasIngredientes
                .Include(l => l.IdIngredienteNavigation)
                .Include(l => l.IdRecetaNavigation)
                .Include(l => l.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdListasIngred == id);
            if (listaIngredientes == null)
            {
                return NotFound();
            }

            _context.Entry(listaIngredientes).State = EntityState.Detached;

            return View(listaIngredientes);
        }

        // POST: ListasIngredientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listasIngredientes = await _context.ListasIngredientes.FindAsync(id);
            _context.ListasIngredientes.Remove(listasIngredientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ListasIngredientesExists(int id)
        {
            return _context.ListasIngredientes.Any(e => e.IdListasIngred == id);
        }
    }
}
