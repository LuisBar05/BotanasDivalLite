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
    public class DetalleVentaController : Controller
    {
        private readonly db_divalContext _context;

        public DetalleVentaController(db_divalContext context)
        {
            _context = context;
        }

        // GET: DetalleVenta
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.DetalleVenta.Include(d => d.CodProductoNavigation).Include(d => d.IdVentaNavigation).Include(d => d.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: DetalleVenta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleVenta = await _context.DetalleVenta
                .Include(d => d.CodProductoNavigation)
                .Include(d => d.IdVentaNavigation)
                .Include(d => d.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdDetVenta == id);
            if (detalleVenta == null)
            {
                return NotFound();
            }

            return View(detalleVenta);
        }

        // GET: DetalleVenta/Create
        public IActionResult Create()
        {
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto");
            ViewData["IdVenta"] = new SelectList(_context.Ventas, "IdVenta", "Status");
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: DetalleVenta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdVenta,CodProducto,Cantidad,Status,Observaciones")] DetalleVenta detalleVenta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detalleVenta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", detalleVenta.CodProducto);
            ViewData["IdVenta"] = new SelectList(_context.Ventas, "IdVenta", "Status", detalleVenta.IdVenta);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", detalleVenta.Status);
            return View(detalleVenta);
        }

        // GET: DetalleVenta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleVenta = await _context.DetalleVenta.FindAsync(id);
            _context.Entry(detalleVenta).State = EntityState.Detached;
            if (detalleVenta == null)
            {
                return NotFound();
            }
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", detalleVenta.CodProducto);
            ViewData["IdVenta"] = new SelectList(_context.Ventas, "IdVenta", "Status", detalleVenta.IdVenta);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", detalleVenta.Status);
            return View(detalleVenta);
        }

        // POST: DetalleVenta/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDetVenta,IdVenta,CodProducto,Cantidad,Status,Observaciones")] DetalleVenta detalleVenta)
        {
            if (id != detalleVenta.IdDetVenta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detalleVenta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleVentaExists(detalleVenta.IdDetVenta))
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
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", detalleVenta.CodProducto);
            ViewData["IdVenta"] = new SelectList(_context.Ventas, "IdVenta", "Status", detalleVenta.IdVenta);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", detalleVenta.Status);
            return View(detalleVenta);
        }

        // GET: DetalleVenta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleVenta = await _context.DetalleVenta
                .Include(d => d.CodProductoNavigation)
                .Include(d => d.IdVentaNavigation)
                .Include(d => d.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdDetVenta == id);
            if (detalleVenta == null)
            {
                return NotFound();
            }

            _context.Entry(detalleVenta).State = EntityState.Detached;

            return View(detalleVenta);
        }

        // POST: DetalleVenta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleVenta = await _context.DetalleVenta.FindAsync(id);
            _context.DetalleVenta.Remove(detalleVenta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetalleVentaExists(int id)
        {
            return _context.DetalleVenta.Any(e => e.IdDetVenta == id);
        }
    }
}
