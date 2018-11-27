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
    public class ProductosController : Controller
    {
        private readonly db_divalContext _context;

        public ProductosController(db_divalContext context)
        {
            _context = context;
        }

        // GET: Productos
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.Productos.Include(p => p.IdPresentacionNavigation).Include(p => p.IdRecetaNavigation).Include(p => p.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: Productos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.IdPresentacionNavigation)
                .Include(p => p.IdRecetaNavigation)
                .Include(p => p.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // GET: Productos/Create
        public IActionResult Create()
        {
            ViewData["IdPresentacion"] = new SelectList(_context.Presentaciones, "IdPresentacion", "Status");
            ViewData["IdReceta"] = new SelectList(_context.Recetas, "IdReceta", "Descripcion");
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: Productos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CodProducto,Descripcion,IdReceta,IdPresentacion,Precio,CostoUnit,Status,Observaciones")] Productos producto)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdPresentacion"] = new SelectList(_context.Presentaciones, "IdPresentacion", "Status", producto.IdPresentacion);
            ViewData["IdReceta"] = new SelectList(_context.Recetas, "IdReceta", "Descripcion", producto.IdReceta);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", producto.Status);
            return View(producto);
        }

        // GET: Productos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos.FindAsync(id);
            _context.Entry(producto).State = EntityState.Detached;
            if (producto == null)
            {
                return NotFound();
            }
            ViewData["IdPresentacion"] = new SelectList(_context.Presentaciones, "IdPresentacion", "Status", producto.IdPresentacion);
            ViewData["IdReceta"] = new SelectList(_context.Recetas, "IdReceta", "Descripcion", producto.IdReceta);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", producto.Status);
            return View(producto);
        }

        // POST: Productos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdProducto,CodProducto,Descripcion,IdReceta,IdPresentacion,Precio,CostoUnit,Status,Observaciones")] Productos producto)
        {
            if (id != producto.IdProducto)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductosExists(producto.IdProducto))
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
            ViewData["IdPresentacion"] = new SelectList(_context.Presentaciones, "IdPresentacion", "Status", producto.IdPresentacion);
            ViewData["IdReceta"] = new SelectList(_context.Recetas, "IdReceta", "Descripcion", producto.IdReceta);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", producto.Status);
            return View(producto);
        }

        // GET: Productos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .Include(p => p.IdPresentacionNavigation)
                .Include(p => p.IdRecetaNavigation)
                .Include(p => p.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdProducto == id);
            if (producto == null)
            {
                return NotFound();
            }

            _context.Entry(producto).State = EntityState.Detached;

            return View(producto);
        }

        // POST: Productos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Productos.FindAsync(id);
            _context.Productos.Remove(producto);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductosExists(int id)
        {
            return _context.Productos.Any(e => e.IdProducto == id);
        }
    }
}
