using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BotanasDIVAL.Models;
using Microsoft.AspNetCore.Http;
using System.Collections;
//using System.Web.UI.MobileControls;

namespace BotanasDIVAL.Controllers
{
    public class VentasController : Controller
    {
        private readonly db_divalContext _context;

        public VentasController(db_divalContext context)
        {
            _context = context;
        }

        // GET: Ventas
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.Ventas.Include(v => v.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: Ventas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas
                .Include(v => v.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdVenta == id);
            if (venta == null)
            {
                return NotFound();
            }

            return View(venta);
        }

        // GET: Ventas/Create
        public IActionResult Create()
        {
            ViewData["CodProducto"] = new SelectList(_context.Productos, "IdProducto", "CodProducto");
            return View();
        }

        // POST: Ventas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection values)
        {
            var i = Convert.ToInt32(values["numDetVenta"]);
            int j, idProduct;
            List<Productos> myList = new List<Productos>();
            Venta mVenta = new Venta();
            mVenta.TotalVenta= 0;
            for (j = 0; j <= i; j++)
            {
                idProduct = Convert.ToInt32(values["codProducto" + j]);
                Productos mProduct= await _context.Productos.Where(d => d.IdProducto==idProduct).SingleAsync();
                myList.Add(mProduct);
                mVenta.TotalVenta += mProduct.CostoUnit*Convert.ToInt32(values["cantidad" + j]);
            }
            mVenta.FechaVenta = DateTime.Parse(values["fechaVenta"]);
            mVenta.Status = "D";
            String obs = values["observacionesVenta"];
            mVenta.Observaciones = (obs.Equals("")) ? null : obs;

            _context.Add(mVenta);
            await _context.SaveChangesAsync();

            for (j = 0; j <= i; j++)
            {
                DetalleVenta mDetVenta = new DetalleVenta();
                mDetVenta.IdVenta = mVenta.IdVenta;
                mDetVenta.CodProducto = myList[j].CodProducto;
                mDetVenta.Cantidad = Convert.ToInt32(values["cantidad" + j]);
                mDetVenta.Status = "D";
                obs = values["observacionesDetVenta" + j];
                mDetVenta.Observaciones = (obs.Equals("")) ? null : obs;

                _context.Add(mDetVenta);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Details", new { id = mVenta.IdVenta});
        }

        // GET: Ventas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas.FindAsync(id);
            _context.Entry(venta).State = EntityState.Detached;
            if (venta == null)
            {
                return NotFound();
            }
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", venta.Status);
            return View(venta);
        }

        // POST: Ventas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVenta,TotalVenta,FechaVenta,Status,Observaciones")] Venta venta)
        {
            if (id != venta.IdVenta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VentasExists(venta.IdVenta))
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
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", venta.Status);
            return View(venta);
        }

        // GET: Ventas/Delete/5
        public async Task<IActionResult> Delete(int? id, String errorMessage)
        {
            if (id == null)
            {
                return NotFound();
            }

            var venta = await _context.Ventas
                .Include(v => v.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdVenta == id);
            if (venta == null)
            {
                return NotFound();
            }

            _context.Entry(venta).State = EntityState.Detached;
            ViewBag.ErrorMessage = errorMessage;
            return View(venta);
        }

        // POST: Ventas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var venta = await _context.Ventas.FindAsync(id);
                _context.Ventas.Remove(venta);
                await _context.SaveChangesAsync();
            }
            catch(InvalidOperationException ex)
            {
                String exceptionMessage = ex.Message;
                return RedirectToAction("Delete", new { idVenta = id, errorMessage = exceptionMessage });
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool VentasExists(int id)
        {
            return _context.Ventas.Any(e => e.IdVenta == id);
        }
    }
}
