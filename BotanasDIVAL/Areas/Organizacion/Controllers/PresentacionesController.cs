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
    public class PresentacionesController : Controller
    {
        private readonly db_divalContext _context;

        public PresentacionesController(db_divalContext context)
        {
            _context = context;
        }

        // GET: Presentaciones
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.Presentaciones.Include(p => p.IdUniMedNavigation).Include(p => p.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: Presentaciones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presentacion = await _context.Presentaciones
                .Include(p => p.IdUniMedNavigation)
                .Include(p => p.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdPresentacion == id);
            if (presentacion == null)
            {
                return NotFound();
            }

            return View(presentacion);
        }

        // GET: Presentaciones/Create
        public IActionResult Create()
        {
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed");
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: Presentaciones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Cantidad,IdUniMed,Status,Observaciones")] Presentaciones presentacion)
        {
            if (ModelState.IsValid)
            {
                presentacion.Status = "D";
                _context.Add(presentacion);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { id = presentacion.IdPresentacion});
            }
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed", presentacion.IdUniMed);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", presentacion.Status);
            return View(presentacion);
        }

        // GET: Presentaciones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presentacion = await _context.Presentaciones.FindAsync(id);
            _context.Entry(presentacion).State = EntityState.Detached;
            if (presentacion == null)
            {
                return NotFound();
            }
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed", presentacion.IdUniMed);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", presentacion.Status);
            return View(presentacion);
        }

        // POST: Presentaciones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPresentacion,Cantidad,IdUniMed,Status,Observaciones")] Presentaciones presentacion)
        {
            if (id != presentacion.IdPresentacion)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(presentacion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PresentacionesExists(presentacion.IdPresentacion))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { id = presentacion.IdPresentacion});
            }
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed", presentacion.IdUniMed);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", presentacion.Status);
            return View(presentacion);
        }

        // GET: Presentaciones/Delete/5
        public async Task<IActionResult> Delete(int? id, String errorMessage)
        {
            if (id == null)
            {
                return NotFound();
            }

            var presentacion = await _context.Presentaciones
                .Include(p => p.IdUniMedNavigation)
                .Include(p => p.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdPresentacion == id);
            if (presentacion == null)
            {
                return NotFound();
            }

            _context.Entry(presentacion).State = EntityState.Detached;
            ViewBag.ErrorMessage = errorMessage;
            return View(presentacion);
        }

        // POST: Presentaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var presentacion = await _context.Presentaciones.FindAsync(id);
                _context.Presentaciones.Remove(presentacion);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                String exceptionMessage = ex.Message;
                return RedirectToAction("Delete", new { idPres = id, errorMessage = exceptionMessage });
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool PresentacionesExists(int id)
        {
            return _context.Presentaciones.Any(e => e.IdPresentacion == id);
        }
    }
}
