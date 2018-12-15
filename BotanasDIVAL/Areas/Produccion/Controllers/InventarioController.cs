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
    public class InventarioController : Controller
    {
        private readonly db_divalContext _context;

        public InventarioController(db_divalContext context)
        {
            _context = context;
        }

        // GET: Inventario
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.Inventario.Include(i => i.CodProductoNavigation).Include(i => i.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: Inventario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventario
                .Include(i => i.CodProductoNavigation)
                .Include(i => i.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdInventario == id);
            if (inventario == null)
            {
                return NotFound();
            }

            return View(inventario);
        }

        // GET: Inventario/Create
        public IActionResult Create()
        {
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto");
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: Inventario/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FechaRegistro,CodProducto,Cantidad,FechaElaboracion,FechaCaducidad,Status,Observaciones")] Inventario inventario)
        {
            if (ModelState.IsValid)
            {
                inventario.Status = "D";
                _context.Add(inventario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", new { id = inventario.IdInventario });
            }
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", inventario.CodProducto);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", inventario.Status);
            return View(inventario);
        }

        // GET: Inventario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventario.FindAsync(id);
            _context.Entry(inventario).State = EntityState.Detached;
            if (inventario == null)
            {
                return NotFound();
            }
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", inventario.CodProducto);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", inventario.Status);
            return View(inventario);
        }

        // POST: Inventario/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdInventario,FechaRegistro,CodProducto,Cantidad,FechaElaboracion,FechaCaducidad,Status,Observaciones")] Inventario inventario)
        {
            if (id != inventario.IdInventario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioExists(inventario.IdInventario))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }          
                }
                return RedirectToAction("Details", new { id = inventario.IdInventario });
            }
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", inventario.CodProducto);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", inventario.Status);
            return View(inventario);
        }

        // GET: Inventario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventario
                .Include(i => i.CodProductoNavigation)
                .Include(i => i.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdInventario == id);
            if (inventario == null)
            {
                return NotFound();
            }

            _context.Entry(inventario).State = EntityState.Detached;

            return View(inventario);
        }

        // POST: Inventario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventario = await _context.Inventario.FindAsync(id);
            _context.Inventario.Remove(inventario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioExists(int id)
        {
            return _context.Inventario.Any(e => e.IdInventario == id);
        }
    }
}
