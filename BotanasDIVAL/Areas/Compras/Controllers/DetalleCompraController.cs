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
    public class DetalleCompraController : Controller
    {
        private readonly DbDivalContext _context;

        public DetalleCompraController(DbDivalContext context)
        {
            _context = context;
        }

        // GET: DetalleCompras
        public async Task<IActionResult> Index(bool isQuery, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (isQuery)
            {
                var db_divalContextQuery = _context.DetalleCompra
                                            .Include(d => d.IdIngredienteNavigation)
                                            .Include(d => d.StatusNavigation)
                                            .Where(d => d.IdCompra == id);
                ViewData["IdCompra"] = id;
                return View(await db_divalContextQuery.ToListAsync());
            }
            else
            {
                var db_divalContext = _context.DetalleCompra.Include(d => d.IdCompraNavigation).Include(d => d.IdIngredienteNavigation).Include(d => d.StatusNavigation);
                return View(await db_divalContext.ToListAsync());
            }
        }

        // GET: DetalleCompras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleCompra = await _context.DetalleCompra
                .Include(d => d.IdCompraNavigation)
                .Include(d => d.IdIngredienteNavigation)
                .Include(d => d.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdDetCompra == id);
            if (detalleCompra == null)
            {
                return NotFound();
            }

            return View(detalleCompra);
        }

        // GET: DetalleCompras/Create
        public IActionResult Create(int? id)
        {
            ViewData["IdCompra"] = id;
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente");
            return View();
        }

        // POST: DetalleCompras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection values)
        {
            var i = Convert.ToInt32(values["numDetCompra"]);
            int j;
            String obs;
            Compra mCompra= await _context.Compras.FindAsync(Convert.ToInt32(values["idCompra"]));
   
            for (j = 0; j <= i; j++)
            {
                mCompra.TotalCompra += (float) Convert.ToDouble(values["precio" + j]);
            }

            for (j = 0; j <= i; j++)
            {
                DetalleCompra mDetCompra = new DetalleCompra();
                mDetCompra.IdCompra = mCompra.IdCompra;
                mDetCompra.IdIngrediente = Convert.ToInt32(values["idIngrediente" + j]);
                mDetCompra.Cantidad = Convert.ToInt32(values["cantidad" + j]);
                mDetCompra.Precio = (float)Convert.ToDouble(values["precio" + j]);
                mDetCompra.Status = "D";
                obs = values["observacionesDetCompra" + j];
                mDetCompra.Observaciones = (String.IsNullOrEmpty(obs)) ? null : obs;
                _context.Add(mDetCompra);       
            }

            await _context.SaveChangesAsync();
            
            return RedirectToAction("Index", new { isQuery="true", id = mCompra.IdCompra });
        }

        // GET: DetalleCompras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleCompra = await _context.DetalleCompra.FindAsync(id);
            _context.Entry(detalleCompra).State = EntityState.Detached;
            if (detalleCompra == null)
            {
                return NotFound();
            }

            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente", detalleCompra.IdIngrediente);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", detalleCompra.Status);
            return View(detalleCompra);
        }

        // POST: DetalleCompras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdDetCompra,IdCompra,IdIngrediente,Cantidad,Precio,Status,Observaciones")] DetalleCompra detalleCompra)
        {
            if (id != detalleCompra.IdDetCompra)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    DetalleCompra mDetCompra= _context.DetalleCompra.Where(d => d.IdDetCompra == id).First();
                    Compra mCompra= _context.Compras.Where(d => d.IdCompra == detalleCompra.IdCompra).First();
                    _context.Entry(mDetCompra).State = EntityState.Detached;
                    float price = detalleCompra.Precio - mDetCompra.Precio;
                    mCompra.TotalCompra += price;
                    _context.Update(detalleCompra);
                    _context.Update(mCompra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DetalleCompraExists(detalleCompra.IdDetCompra))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { id = detalleCompra.IdDetCompra });
            }

            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente", detalleCompra.IdIngrediente);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", detalleCompra.Status);
            return View(detalleCompra);
        }

        // GET: DetalleCompras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var detalleCompra = await _context.DetalleCompra
                .Include(d => d.IdCompraNavigation)
                .Include(d => d.IdIngredienteNavigation)
                .Include(d => d.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdDetCompra == id);
            if (detalleCompra == null)
            {
                return NotFound();
            }

            _context.Entry(detalleCompra).State = EntityState.Detached;

            return View(detalleCompra);
        }

        // POST: DetalleCompras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var detalleCompra = await _context.DetalleCompra.FindAsync(id);
            var mCompra = await _context.Compras.FindAsync(detalleCompra.IdCompra);
            mCompra.TotalCompra -= detalleCompra.Precio;
            _context.DetalleCompra.Remove(detalleCompra);
            _context.Update(mCompra);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { isQuery="true", id=mCompra.IdCompra});
        }

        private bool DetalleCompraExists(int id)
        {
            return _context.DetalleCompra.Any(e => e.IdDetCompra == id);
        }
    }
}
