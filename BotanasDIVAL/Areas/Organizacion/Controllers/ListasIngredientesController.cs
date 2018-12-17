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
    public class ListasIngredientesController : Controller
    {
        private readonly DbDivalContext _context;

        public ListasIngredientesController(DbDivalContext context)
        {
            _context = context;
        }

        // GET: ListasIngredientes
        public async Task<IActionResult> Index(bool isQuery, int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (isQuery)
            {
                var db_divalContextQuery = _context.ListasIngredientes
                                            .Include(d => d.IdIngredienteNavigation)
                                            .Include(d => d.StatusNavigation)
                                            .Include(d => d.IdRecetaNavigation)
                                            .Where(d => d.IdReceta == id);
                ViewData["IdReceta"] = id;
                return View(await db_divalContextQuery.ToListAsync());
            }
            else
            {
                var db_divalContext = _context.ListasIngredientes.Include(l => l.IdIngredienteNavigation).Include(l => l.IdRecetaNavigation).Include(l => l.StatusNavigation);
                return View(await db_divalContext.ToListAsync());
            }
           
        }

        // GET: ListasIngredientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaIngredientes = await _context.ListasIngredientes
                .Include(l => l.IdIngredienteNavigation)
                .Include(l => l.IdRecetaNavigation)
                .Include(l => l.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdListasIngred == id);
            if (listaIngredientes == null)
            {
                return NotFound();
            }

            return View(listaIngredientes);
        }

        // GET: ListasIngredientes/Create
        public IActionResult Create(int? id)
        {
            ViewData["IdReceta"] = id;
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente");
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus");
            return View();
        }

        // POST: ListasIngredientes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection values)
        {
            var i = Convert.ToInt32(values["numListIngredientes"]);
            var idReceta= Convert.ToInt32(values["idReceta"]);
            String obs;

            for (int j = 0; j <= i; j++)
            {
                ListasIngredientes mListIngredientes = new ListasIngredientes();
                mListIngredientes.IdReceta = idReceta;
                mListIngredientes.IdIngrediente = Convert.ToInt32(values["idIngrediente" + j]);
                mListIngredientes.Cantidad = Convert.ToInt32(values["cantidad" + j]);
                mListIngredientes.Status = "D";
                obs = values["obsIngrediente" + j];
                mListIngredientes.Observaciones = (String.IsNullOrEmpty(obs)) ? null : obs;
                _context.Add(mListIngredientes);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index", new { isQuery = "true", id = idReceta });
        }

        // GET: ListasIngredientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaIngredientes = await _context.ListasIngredientes.FindAsync(id);
            _context.Entry(listaIngredientes).State = EntityState.Detached;
            if (listaIngredientes == null)
            {
                return NotFound();
            }
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente", listaIngredientes.IdIngrediente);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", listaIngredientes.Status);
            return View(listaIngredientes);
        }

        // POST: ListasIngredientes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdListasIngred,IdReceta,IdIngrediente,Cantidad,Status,Observaciones")] ListasIngredientes listaIngredientes)
        {
            if (id != listaIngredientes.IdListasIngred)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(listaIngredientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ListasIngredientesExists(listaIngredientes.IdListasIngred))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { id = listaIngredientes.IdListasIngred});
            }
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente", listaIngredientes.IdIngrediente);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", listaIngredientes.Status);
            return View(listaIngredientes);
        }

        // GET: ListasIngredientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var listaIngredientes = await _context.ListasIngredientes
                .Include(l => l.IdIngredienteNavigation)
                .Include(l => l.IdRecetaNavigation)
                .Include(l => l.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdListasIngred == id);
            if (listaIngredientes == null)
            {
                return NotFound();
            }

            _context.Entry(listaIngredientes).State = EntityState.Detached;

            return View(listaIngredientes);
        }

        // POST: ListasIngredientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var listasIngredientes = await _context.ListasIngredientes.FindAsync(id);
            _context.ListasIngredientes.Remove(listasIngredientes);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { isQuery = "true", id = listasIngredientes.IdReceta });
        }

        private bool ListasIngredientesExists(int id)
        {
            return _context.ListasIngredientes.Any(e => e.IdListasIngred == id);
        }
    }
}
