using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BotanasDIVAL.Models;
using Microsoft.AspNetCore.Http;

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
        public async Task<IActionResult> Index(bool isQuery, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (isQuery)
            {
                var db_divalContextQuery = _context.DetalleVenta
                                            .Include(d => d.CodProductoNavigation)
                                            .Include(d => d.StatusNavigation)
                                            .Where(d => d.IdVenta == id);
                
                List<Productos> mListProducts = new List<Productos>();
                foreach (var item in db_divalContextQuery.ToList())
                {
                    Productos mProduct = _context.Productos.Where(d=>d.CodProducto==item.CodProducto).Single();
                    mListProducts.Add(mProduct);
                }

                ViewData["IdVenta"] = id;
                ViewData["Products"] = mListProducts;
                return View(await db_divalContextQuery.ToListAsync());
            }
            else
            {
                var db_divalContext = _context.DetalleVenta.Include(d => d.CodProductoNavigation).Include(d => d.StatusNavigation);
                return View(await db_divalContext.ToListAsync());
            }
        }

        // GET: DetalleVenta/Details/5
        public async Task<IActionResult> Details(int? id, float cost)
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

            ViewData["CostUnit"] = cost;

            return View(detalleVenta);
        }

        // GET: DetalleVenta/Create
        public IActionResult Create(int? id)
        {
            ViewData["CodProducto"] = new SelectList(_context.Productos, "IdProducto", "CodProducto");
            ViewData["IdVenta"] = id;
            return View();
        }

        // POST: DetalleVenta/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection values)
        {
            var i = Convert.ToInt32(values["numDetVenta"]);
            int j, idProduct;
            String obs;
            List<Productos> myList = new List<Productos>();
            Venta mVenta = await _context.Ventas.FindAsync(Convert.ToInt32(values["idVenta"]));
            for (j = 0; j <= i; j++)
            {
                idProduct = Convert.ToInt32(values["codProducto" + j]);
                Productos mProduct = await _context.Productos.Where(d => d.IdProducto == idProduct).SingleAsync();
                myList.Add(mProduct);
                mVenta.TotalVenta += mProduct.CostoUnit * Convert.ToInt32(values["cantidad" + j]);
            }

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
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { isQuery = "true", id = mVenta.IdVenta });
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
            //ViewData["IdVenta"] = new SelectList(_context.Ventas, "IdVenta", "Status", detalleVenta.IdVenta);
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
                    DetalleVenta mDetVenta = _context.DetalleVenta.Where(d => d.IdDetVenta == id).First();
                    Productos mOldProduct= _context.Productos.Where(d => d.CodProducto == mDetVenta.CodProducto).First();
                    Productos mNewProduct = _context.Productos.Where(d => d.CodProducto == detalleVenta.CodProducto).First();
                    Venta mVenta = _context.Ventas.Where(d => d.IdVenta == detalleVenta.IdVenta).First();
                    _context.Entry(mDetVenta).State = EntityState.Detached;
                    float price = (mNewProduct.CostoUnit*detalleVenta.Cantidad) - (mOldProduct.CostoUnit*mDetVenta.Cantidad);
                    mVenta.TotalVenta += price;
                    _context.Update(detalleVenta);
                    _context.Update(mVenta);
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
                return RedirectToAction("Details", new { id = detalleVenta.IdDetVenta });
            }

            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", detalleVenta.CodProducto);
            //ViewData["IdVenta"] = new SelectList(_context.Ventas, "IdVenta", "Status", detalleVenta.IdVenta);
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
            DetalleVenta mDetVenta = await _context.DetalleVenta.FindAsync(id);
            Productos mProduct = _context.Productos.Where(d => d.CodProducto == mDetVenta.CodProducto).First();
            var mVenta = await _context.Ventas.FindAsync(mDetVenta.IdVenta);
            mVenta.TotalVenta -= mDetVenta.Cantidad * mProduct.CostoUnit;
            _context.DetalleVenta.Remove(mDetVenta);
            _context.Update(mVenta);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { isQuery = "true", id = mVenta.IdVenta });
        }

        private bool DetalleVentaExists(int id)
        {
            return _context.DetalleVenta.Any(e => e.IdDetVenta == id);
        }
    }
}
