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
    public class DetallePedidoController : Controller
    {
        private readonly db_divalContext _context;

        public DetallePedidoController(db_divalContext context)
        {
            _context = context;
        }

        // GET: DetallePedidoes
        public async Task<IActionResult> Index(bool isQuery, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (isQuery)
            {
                var db_divalContextQuery = _context.DetallePedido
                                            .Include(d => d.CodProductoNavigation)
                                            .Include(d => d.StatusNavigation)
                                            .Where(d => d.IdPedido == id);

                List<Productos> mListProducts = new List<Productos>();
                foreach (var item in db_divalContextQuery.ToList())
                {
                    Productos mProduct = _context.Productos.Where(d => d.CodProducto == item.CodProducto).Single();
                    mListProducts.Add(mProduct);
                }

                ViewData["IdPedido"] = id;
                ViewData["Products"] = mListProducts;
                return View(await db_divalContextQuery.ToListAsync());
            }
            else
            {
                var db_divalContext = _context.DetallePedido.Include(d => d.CodProductoNavigation).Include(d => d.StatusNavigation);
                return View(await db_divalContext.ToListAsync());
            }
        }

        // GET: DetallePedidoes/Details/5
        public async Task<IActionResult> Details(int? id, float cost)
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

            ViewData["CostUnit"] = cost;

            return View(detallePedido);
        }

        // GET: DetallePedidoes/Create
        public IActionResult Create(int? id)
        {
            ViewData["CodProducto"] = new SelectList(_context.Productos, "IdProducto", "CodProducto");
            ViewData["IdPedido"] = id;
            return View();
        }

        // POST: DetallePedidoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection values)
        {
            var i = Convert.ToInt32(values["numDetPedido"]);
            int j, idProduct;
            String obs;
            List<Productos> myList = new List<Productos>();
            Pedidos mPedido = await _context.Pedidos.FindAsync(Convert.ToInt32(values["idPedido"]));
            for (j = 0; j <= i; j++)
            {
                idProduct = Convert.ToInt32(values["codProducto" + j]);
                Productos mProduct = await _context.Productos.Where(d => d.IdProducto == idProduct).SingleAsync();
                myList.Add(mProduct);
                mPedido.TotalPedido += mProduct.CostoUnit * Convert.ToInt32(values["cantidad" + j]);
            }

            for (j = 0; j <= i; j++)
            {
                DetallePedido mDetPedido = new DetallePedido();
                mDetPedido.IdPedido = mPedido.IdPedido;
                mDetPedido.CodProducto = myList[j].CodProducto;
                mDetPedido.Cantidad = Convert.ToInt32(values["cantidad" + j]);
                mDetPedido.Status = "D";
                obs = values["obsDetPedido" + j];
                mDetPedido.Observaciones = (obs.Equals("")) ? null : obs;

                _context.Add(mDetPedido);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { isQuery = "true", id = mPedido.IdPedido });
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
                    DetallePedido mDetPedido = _context.DetallePedido.Where(d => d.IdDetPedido == id).First();
                    Productos mOldProduct = _context.Productos.Where(d => d.CodProducto == mDetPedido.CodProducto).First();
                    Productos mNewProduct = _context.Productos.Where(d => d.CodProducto == detallePedido.CodProducto).First();
                    Pedidos mPedido = _context.Pedidos.Where(d => d.IdPedido == detallePedido.IdPedido).First();
                    _context.Entry(mDetPedido).State = EntityState.Detached;
                    float price = (mNewProduct.CostoUnit * detallePedido.Cantidad) - (mOldProduct.CostoUnit * mDetPedido.Cantidad);
                    mPedido.TotalPedido += price;
                    _context.Update(detallePedido);
                    _context.Update(mPedido);
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
                return RedirectToAction("Details", new { id = detallePedido.IdDetPedido });
            }
            ViewData["CodProducto"] = new SelectList(_context.Productos, "CodProducto", "CodProducto", detallePedido.CodProducto);
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
            DetallePedido mDetPedido = await _context.DetallePedido.FindAsync(id);
            Productos mProduct = _context.Productos.Where(d => d.CodProducto == mDetPedido.CodProducto).First();
            var mPedido = await _context.Pedidos.FindAsync(mDetPedido.IdPedido); 
            mPedido.TotalPedido -= mDetPedido.Cantidad * mProduct.CostoUnit;
            _context.DetallePedido.Remove(mDetPedido);   
            _context.Update(mPedido);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { isQuery = "true", id = mPedido.IdPedido });
        }

        private bool DetallePedidoExists(int id)
        {
            return _context.DetallePedido.Any(e => e.IdDetPedido == id);
        }
    }
}
