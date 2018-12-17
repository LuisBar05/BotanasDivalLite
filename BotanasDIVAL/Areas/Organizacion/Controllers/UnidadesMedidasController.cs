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
    public class UnidadesMedidasController : Controller
    {
        private readonly DbDivalContext _context;

        public UnidadesMedidasController(DbDivalContext context)
        {
            _context = context;
        }

        // GET: UnidadesMedidas
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.UnidadesMedida.Include(u => u.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: UnidadesMedidas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidadMedida = await _context.UnidadesMedida
                .Include(u => u.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdUniMed == id);
            if (unidadMedida == null)
            {
                return NotFound();
            }

            return View(unidadMedida);
        }

        // GET: UnidadesMedidas/Create
        public IActionResult Create(String errorMessage)
        {
            ViewBag.ErrorMessage = errorMessage;
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: UnidadesMedidas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DescripcionUniMed,Status,Observaciones")] UnidadesMedida unidadMedida)
        {
            if (ModelState.IsValid)
            {
                unidadMedida.Status = "D";
                String uniMedName = unidadMedida.DescripcionUniMed;
                try
                {
                    await _context.UnidadesMedida
                        .Where(d => d.DescripcionUniMed == uniMedName).SingleAsync();
                }
                catch(InvalidOperationException)
                {
                    _context.Add(unidadMedida);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details", new { id = unidadMedida.IdUniMed });
                }
                String message = "UnidadMedidaError";
                return RedirectToAction("Create", new { errorMessage = message });

            }
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", unidadMedida.Status);
            return View(unidadMedida);
        }

        // GET: UnidadesMedidas/Edit/5
        public async Task<IActionResult> Edit(int? id, String errorMessage)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidadMedida = await _context.UnidadesMedida.FindAsync(id);
            _context.Entry(unidadMedida).State = EntityState.Detached;
            if (unidadMedida == null)
            {
                return NotFound();
            }
            ViewBag.ErrorMessage = errorMessage;
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", unidadMedida.Status);
            return View(unidadMedida);
        }

        // POST: UnidadesMedidas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdUniMed,DescripcionUniMed,Status,Observaciones")] UnidadesMedida unidadMedida)
        {
            if (id != unidadMedida.IdUniMed)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                UnidadesMedida mUniMed = await _context.UnidadesMedida
                        .Where(d => d.IdUniMed == id).SingleAsync();
                try
                {
                    if (mUniMed.DescripcionUniMed.Equals(unidadMedida.DescripcionUniMed))
                    {
                        _context.Update(unidadMedida);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Details", new { id = unidadMedida.IdUniMed});

                    }
                    else
                    {
                        await _context.UnidadesMedida
                        .Where(d => d.DescripcionUniMed == unidadMedida.DescripcionUniMed).SingleAsync();
                    }
                }
                catch (Exception ex)
                {
                    if (ex is InvalidOperationException)
                    {
                        _context.Entry(mUniMed).State = EntityState.Detached;
                        _context.Update(unidadMedida);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Details", new { id = unidadMedida.IdUniMed });
                    }

                    else if (ex is DbUpdateConcurrencyException)
                    {
                        if (!UnidadesMedidaExists(unidadMedida.IdUniMed))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                String message = "UnidadMedidaError";
                return RedirectToAction("Edit", new { errorMessage = message });
            }
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", unidadMedida.Status);
            return View(unidadMedida);
        }

        // GET: UnidadesMedidas/Delete/5
        public async Task<IActionResult> Delete(int? id, String errorMessage)
        {
            if (id == null)
            {
                return NotFound();
            }

            var unidadMedida = await _context.UnidadesMedida
                .Include(u => u.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdUniMed == id);
            if (unidadMedida == null)
            {
                return NotFound();
            }

            _context.Entry(unidadMedida).State = EntityState.Detached;
            ViewBag.ErrorMessage = errorMessage;
            return View(unidadMedida);
        }

        // POST: UnidadesMedidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var unidadMedida = await _context.UnidadesMedida.FindAsync(id);
                _context.UnidadesMedida.Remove(unidadMedida);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                String exceptionMessage = ex.Message;
                return RedirectToAction("Delete", new { idPres = id, errorMessage = exceptionMessage });
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool UnidadesMedidaExists(int id)
        {
            return _context.UnidadesMedida.Any(e => e.IdUniMed == id);
        }
    }
}
