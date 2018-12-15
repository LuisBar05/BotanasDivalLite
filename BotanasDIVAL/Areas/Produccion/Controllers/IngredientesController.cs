using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BotanasDIVAL.Models;
using MySql.Data.MySqlClient;

namespace BotanasDIVAL.Controllers
{
    public class IngredientesController : Controller
    {
        private readonly db_divalContext _context;

        public IngredientesController(db_divalContext context)
        {
            _context = context;
        }

        // GET: Ingredientes
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.Ingredientes.Include(i => i.IdUniMedNavigation).Include(i => i.StatusNavigation);
            return View(await db_divalContext.OrderBy(item => item.IdIngrediente).ToListAsync());
        }

        // GET: Ingredientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingrediente = await _context.Ingredientes
                .Include(i => i.IdUniMedNavigation)
                .Include(i => i.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdIngrediente == id);
            if (ingrediente == null)
            {
                return NotFound();
            }

            return View(ingrediente);
        }

        // GET: Ingredientes/Create
        public IActionResult Create()
        {
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed");
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: Ingredientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NombreIngrediente,Cantidad,IdUniMed,Status,Observaciones")] Ingredientes ingrediente)
        {
            if (ModelState.IsValid)
            {
                ingrediente.Status = "D";
                _context.Add(ingrediente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { id = ingrediente.IdIngrediente });
            }
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed", ingrediente.IdUniMed);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", ingrediente.Status);
            return View(ingrediente);
        }

        // GET: Ingredientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingrediente = await _context.Ingredientes.FindAsync(id);
            _context.Entry(ingrediente).State = EntityState.Detached;

            if (ingrediente == null)
            {
                return NotFound();
            }
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed", ingrediente.IdUniMed);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", ingrediente.Status);
            return View(ingrediente);
        }

        // POST: Ingredientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdIngrediente, NombreIngrediente,Cantidad,IdUniMed,Status,Observaciones")] Ingredientes ingrediente)
        {
            if (id != ingrediente.IdIngrediente)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ingrediente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IngredientesExists(ingrediente.IdIngrediente))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { id = ingrediente.IdIngrediente });
            }
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed", ingrediente.IdUniMed);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", ingrediente.Status);
            return View(ingrediente);
        }

        // GET: Ingredientes/Delete/5
        public async Task<IActionResult> Delete(int? id, String errorMessage)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ingrediente = await _context.Ingredientes
                .Include(i => i.IdUniMedNavigation)
                .Include(i => i.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdIngrediente == id);
            if (ingrediente == null)
            {
                return NotFound();
            }

            _context.Entry(ingrediente).State = EntityState.Detached;
            ViewBag.ErrorMessage = errorMessage;
            return View(ingrediente);
        }

        // POST: Ingredientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var ingrediente = await _context.Ingredientes.FindAsync(id);
                _context.Ingredientes.Remove(ingrediente);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException ex)
            {
                String exceptionMessage = ex.Message;
                return RedirectToAction("Delete", new { idIngred = id, errorMessage = exceptionMessage });

            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool IngredientesExists(int id)
        {
            return _context.Ingredientes.Any(e => e.IdIngrediente == id);
        }
    }
}
