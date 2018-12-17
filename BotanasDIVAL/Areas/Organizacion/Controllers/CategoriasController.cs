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
    public class CategoriasController : Controller
    {
        private readonly DbDivalContext _context;

        public CategoriasController(DbDivalContext context)
        {
            _context = context;
        }

        // GET: Categorias
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.Categorias.Include(c => c.StatusNavigation);
            return View(await db_divalContext.OrderBy(item => item.IdCategoria).ToListAsync());
        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categorias
                .Include(c => c.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdCategoria == id);
            if (categoria == null)
            {
                return NotFound();
            }

            return View(categoria);
        }

        // GET: Categorias/Create
        public IActionResult Create(String errorMessage)
        {
            ViewBag.ErrorMessage = errorMessage;
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: Categorias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NombreCategoria,Status,Observaciones")] Categorias categoria)
        {
            if (ModelState.IsValid)
            {
                categoria.Status = "D";
                try
                {
                    await _context.Categorias
                        .Where(d => d.NombreCategoria == categoria.NombreCategoria).SingleAsync();
                }
                catch(InvalidOperationException)
                {
                    _context.Add(categoria);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Details", new { id = categoria.IdCategoria });
                }
                String message = "CategoryError";
                return RedirectToAction("Create", new { errorMessage = message });

            }
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", categoria.Status);
            return View(categoria);
        }

        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(int? id, String errorMessage)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categorias.FindAsync(id);
            _context.Entry(categoria).State = EntityState.Detached;
            if (categoria == null)
            {
                return NotFound();
            }
            ViewBag.ErrorMessage=errorMessage;
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", categoria.Status);
            return View(categoria);
        }

        // POST: Categorias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCategoria,NombreCategoria,Status,Observaciones")] Categorias categoria)
        {
            if (id != categoria.IdCategoria)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                Categorias mCat = await _context.Categorias
                        .Where(d => d.IdCategoria == id).SingleAsync();
                try
                {    
                    if (mCat.NombreCategoria.Equals(categoria.NombreCategoria))
                    {
                        _context.Update(categoria);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Details", new { id = categoria.IdCategoria });
                        
                    }
                    else
                    {
                        await _context.Categorias
                        .Where(d => d.NombreCategoria == categoria.NombreCategoria).SingleAsync();
                    }
                    
                }
                catch (Exception ex)
                {
                    if(ex is InvalidOperationException)
                    {
                        _context.Entry(mCat).State = EntityState.Detached;
                        _context.Update(categoria);
                        await _context.SaveChangesAsync();
                        return RedirectToAction("Details", new { id = categoria.IdCategoria });
                    }
                   
                    else if(ex is DbUpdateConcurrencyException)
                    {
                        if (!CategoriasExists(categoria.IdCategoria))
                        {
                            return NotFound();
                        }
                        else
                        {
                            throw;
                        }
                    }
                }

                String message = "CategoryError";
                return RedirectToAction("Edit", new { errorMessage = message });
            }
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", categoria.Status);
            return View(categoria);
        }

        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(int? id, String errorMessage)
        {
            if (id == null)
            {
                return NotFound();
            }

            var categoria = await _context.Categorias
                .Include(c => c.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdCategoria == id);

            if (categoria == null)
            {
                return NotFound();
            }

            _context.Entry(categoria).State = EntityState.Detached;
            ViewBag.ErrorMessage = errorMessage;    
            return View(categoria);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var categoria = await _context.Categorias.FindAsync(id);
                _context.Categorias.Remove(categoria);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                String exceptionMessage = ex.Message;
                return RedirectToAction("Delete", new {idCat=id, errorMessage=exceptionMessage});
            }
        
            return RedirectToAction(nameof(Index));
        }

        private bool CategoriasExists(int id)
        {
            return _context.Categorias.Any(e => e.IdCategoria == id);
        }
    }
}
