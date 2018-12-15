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
    public class PedidosController : Controller
    {
        private readonly db_divalContext _context;

        public PedidosController(db_divalContext context)
        {
            _context = context;
        }

        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.Pedidos.Include(p => p.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdPedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            ViewData["CodProducto"] = new SelectList(_context.Productos, "IdProducto", "CodProducto");
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection values)
        {
            var i = Convert.ToInt32(values["numDetPedido"]);
            int j, idProduct;
            List<Productos> myList = new List<Productos>();
            Pedidos mPedido = new Pedidos();
            mPedido.Cliente = values["cliente"];
            mPedido.TotalPedido = 0;
            for (j = 0; j <= i; j++)
            {
                idProduct = Convert.ToInt32(values["codProducto" + j]);
                Productos mProduct = await _context.Productos.Where(d => d.IdProducto == idProduct).SingleAsync();
                myList.Add(mProduct);
                mPedido.TotalPedido += mProduct.CostoUnit * Convert.ToInt32(values["cantidad" + j]);
            }
            mPedido.FechaPedido = DateTime.Parse(values["fechaPedido"]);
            mPedido.FechaEntrega = DateTime.Parse(values["fechaEntrega"]);
            mPedido.Status = "D";
            String obs = values["obsPedido"];
            mPedido.Observaciones = (obs.Equals("")) ? null : obs;

            _context.Add(mPedido);
            await _context.SaveChangesAsync();

            for (j = 0; j <= i; j++)
            {
                DetallePedido mDetPedido = new DetallePedido();
                mDetPedido.IdPedido= mPedido.IdPedido;
                mDetPedido.CodProducto = myList[j].CodProducto;
                mDetPedido.Cantidad = Convert.ToInt32(values["cantidad" + j]);
                mDetPedido.Status = "D";
                obs = values["obsDetPedido" + j];
                mDetPedido.Observaciones = (obs.Equals("")) ? null : obs;

                _context.Add(mDetPedido);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Details", new { id = mPedido.IdPedido});
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos.FindAsync(id);
            _context.Entry(pedido).State = EntityState.Detached;
            if (pedido == null)
            {
                return NotFound();
            }
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", pedido.Status);
            return View(pedido);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdPedido,Cliente,TotalPedido,FechaPedido,FechaEntrega,Status,Observaciones")] Pedidos pedido)
        {
            if (id != pedido.IdPedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidosExists(pedido.IdPedido))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { id = pedido.IdPedido});
            }
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", pedido.Status);
            return View(pedido);
        }

        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id, String errorMessage)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .Include(p => p.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdPedido == id);
            if (pedido == null)
            {
                return NotFound();
            }

            _context.Entry(pedido).State = EntityState.Detached;
            ViewBag.ErrorMessage = errorMessage;
            return View(pedido);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var pedido = await _context.Pedidos.FindAsync(id);
                _context.Pedidos.Remove(pedido);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                String exceptionMessage = ex.Message;
                return RedirectToAction("Delete", new { idPedido = id, errorMessage = exceptionMessage });
            }
            return RedirectToAction(nameof(Index));
        }

        private bool PedidosExists(int id)
        {
            return _context.Pedidos.Any(e => e.IdPedido == id);
        }
    }
}
