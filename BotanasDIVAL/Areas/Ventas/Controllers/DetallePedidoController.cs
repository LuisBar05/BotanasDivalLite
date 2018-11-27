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
    public class DetallePedidoController : Controller
    {
        private readonly db_divalContext _context;

        public DetallePedidoController(db_divalContext context)
        {
            _context = context;
        }

        // GET: DetallePedidoes
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.DetallePedido.Include(d => d.CodProductoNavigation).Include(d => d.IdPedidoNavigation).Include(d => d.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: DetallePedidoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detallePedido = await _context.DetallePedido
                .Include(d => d.CodProductoNavigation)
                .Include(d => d.IdPedidoNavigation)
                .Include(d => d.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdDetPedido == id);
            if (detallePedido == null)
            {
                return NotFound();
            }

            return View(detallePedido);
        }

        // GET: DetallePedidoes/Create
        public IActionResult Create()
        {
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto");
            ViewData["IdPedido"] = new SelectList(_context.Pedidos, "IdPedido", "Cliente");
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: DetallePedidoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdPedido,CodProducto,Cantidad,Status,Observaciones")] DetallePedido detallePedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(detallePedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", detallePedido.CodProducto);
            ViewData["IdPedido"] = new SelectList(_context.Pedidos, "IdPedido", "Cliente", detallePedido.IdPedido);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", detallePedido.Status);
            return View(detallePedido);
        }

        // GET: DetallePedidoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detallePedido = await _context.DetallePedido.FindAsync(id);
            _context.Entry(detallePedido).State = EntityState.Detached;
            if (detallePedido == null)
            {
                return NotFound();
            }
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", detallePedido.CodProducto);
            ViewData["IdPedido"] = new SelectList(_context.Pedidos, "IdPedido", "Cliente", detallePedido.IdPedido);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", detallePedido.Status);
            return View(detallePedido);
        }

        // POST: DetallePedidoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDetPedido,IdPedido,CodProducto,Cantidad,Status,Observaciones")] DetallePedido detallePedido)
        {
            if (id != detallePedido.IdDetPedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(detallePedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetallePedidoExists(detallePedido.IdDetPedido))
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
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", detallePedido.CodProducto);
            ViewData["IdPedido"] = new SelectList(_context.Pedidos, "IdPedido", "Cliente", detallePedido.IdPedido);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", detallePedido.Status);
            return View(detallePedido);
        }

        // GET: DetallePedidoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detallePedido = await _context.DetallePedido
                .Include(d => d.CodProductoNavigation)
                .Include(d => d.IdPedidoNavigation)
                .Include(d => d.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdDetPedido == id);
            if (detallePedido == null)
            {
                return NotFound();
            }

            _context.Entry(detallePedido).State = EntityState.Detached;

            return View(detallePedido);
        }

        // POST: DetallePedidoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detallePedido = await _context.DetallePedido.FindAsync(id);
            _context.DetallePedido.Remove(detallePedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DetallePedidoExists(int id)
        {
            return _context.DetallePedido.Any(e => e.IdDetPedido == id);
        }
    }
}
