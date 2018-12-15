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
    public class ComprasController : Controller
    {
        private readonly db_divalContext _context;

        public ComprasController(db_divalContext context)
        {
            _context = context;
        }

        // GET: Compras
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.Compras.Include(c => c.StatusNavigation);
            return View(await db_divalContext.OrderBy(item=>item.IdCompra).ToListAsync());
        }

        // GET: Compras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compras
                .Include(c => c.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdCompra == id);
            if (compra == null)
            {
                return NotFound();
            }

            return View(compra);
        }

        // GET: Compras/Create
        public IActionResult Create()
        {
            //ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente");
            return View();
        }

        // POST: Compras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection values)
        {
            var i = Convert.ToInt32(values["numDetCompra"]);
            int j;
            Compra mCompra = new Compra();
            mCompra.TotalCompra = 0;
            for (j = 0; j <= i; j++)
            {
                mCompra.TotalCompra += (float) Convert.ToDouble(values["precio"+j]);
            }
            mCompra.FechaCompra = DateTime.Parse(values["fechaCompra"]);
            mCompra.LugarCompra = values["lugarCompra"];
            mCompra.Status = "D";
            String obs = values["observacionesCompra"];
            mCompra.Observaciones = (obs.Equals("")) ? null : obs;

            _context.Add(mCompra);
            await _context.SaveChangesAsync();

            for (j=0;j<=i;j++)
            {
                DetalleCompra mDetCompra = new DetalleCompra();
                mDetCompra.IdCompra = mCompra.IdCompra;
                mDetCompra.IdIngrediente =Convert.ToInt32(values["idIngrediente" + j]);
                mDetCompra.Cantidad = Convert.ToInt32(values["cantidad" + j]);
                mDetCompra.Precio= (float)Convert.ToDouble(values["precio" + j]);
                mDetCompra.Status = "D";
                obs = values["observacionesDetCompra" + j];
                mDetCompra.Observaciones = (obs.Equals("")) ? null : obs;

                _context.Add(mDetCompra);
                await _context.SaveChangesAsync();         
            }
           
            return RedirectToAction("Details", new {id=mCompra.IdCompra });
        }

        // GET: Compras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compras.FindAsync(id);
            
            if (compra == null)
            {
                return NotFound();
            }
            _context.Entry(compra).State = EntityState.Detached;
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", compra.Status);
            return View(compra);
        }

        // POST: Compras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdCompra,TotalCompra,FechaCompra,LugarCompra,Status,Observaciones")] Compra compra)
        {
            if (id != compra.IdCompra)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComprasExists(compra.IdCompra))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new {id=compra.IdCompra });
            }
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", compra.Status);
            return View(compra);
        }

        // GET: Compras/Delete/5
        public async Task<IActionResult> Delete(int? id, String errorMessage)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compra = await _context.Compras
                .Include(c => c.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdCompra == id);
            if (compra == null)
            {
                return NotFound();
            }

            _context.Entry(compra).State = EntityState.Detached;
            ViewBag.ErrorMessage = errorMessage;
            return View(compra);
        }

        // POST: Compras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var compra = await _context.Compras.FindAsync(id);
                _context.Compras.Remove(compra);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                String exceptionMessage = ex.Message;
                return RedirectToAction("Delete", new { idCompra = id, errorMessage = exceptionMessage });
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool ComprasExists(int id)
        {
            return _context.Compras.Any(e => e.IdCompra == id);
        }
    }
}
