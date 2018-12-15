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
    public class RecetasController : Controller
    {
        private readonly db_divalContext _context;

        public RecetasController(db_divalContext context)
        {
            _context = context;
        }

        // GET: Recetas
        public async Task<IActionResult> Index()
        {
            var db_divalContext = _context.Recetas.Include(r => r.IdCategoriaNavigation).Include(r => r.IdUniMedNavigation).Include(r => r.StatusNavigation);
            return View(await db_divalContext.ToListAsync());
        }

        // GET: Recetas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receta = await _context.Recetas
                .Include(r => r.IdCategoriaNavigation)
                .Include(r => r.IdUniMedNavigation)
                .Include(r => r.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdReceta == id);
            if (receta == null)
            {
                return NotFound();
            }

            return View(receta);
        }

        // GET: Recetas/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "IdCategoria", "NombreCategoria");
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed");
            ViewData["IdIngrediente"] = new SelectList(_context.Ingredientes, "IdIngrediente", "NombreIngrediente");
            return View();
        }

        // POST: Recetas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(IFormCollection values)
        {
            var i = Convert.ToInt32(values["numListIngredientes"]);
            int j;
            Recetas mReceta = new Recetas();
            mReceta.IdCategoria= Convert.ToInt32(values["idCategoria"]);
            mReceta.Descripcion= values["descripcion"];
            mReceta.Merma= (float) Convert.ToDouble(values["merma"]);
            mReceta.IdUniMed= Convert.ToInt32(values["idUniMed"]);
            mReceta.CostoKilo= (float) Convert.ToDouble(values["costKilo"]);
            mReceta.Status = "D";
            String obs = values["obsReceta"];
            mReceta.Observaciones = (obs.Equals("")) ? null : obs;

            _context.Add(mReceta);
            await _context.SaveChangesAsync();

            for (j = 0; j <= i; j++)
            {
                ListasIngredientes mListIngredientes = new ListasIngredientes();
                mListIngredientes.IdReceta = mReceta.IdReceta;
                mListIngredientes.IdIngrediente = Convert.ToInt32(values["idIngrediente" + j]);
                mListIngredientes.Cantidad = Convert.ToInt32(values["cantidad" + j]);
                mListIngredientes.Status = "D";
                obs = values["obsIngrediente" + j];
                mListIngredientes.Observaciones = (obs.Equals("")) ? null : obs;

                _context.Add(mListIngredientes);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id = mReceta.IdReceta });
        }

        // GET: Recetas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receta = await _context.Recetas.FindAsync(id);
            _context.Entry(receta).State = EntityState.Detached;
            if (receta == null)
            {
                return NotFound();
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "IdCategoria", "NombreCategoria", receta.IdCategoria);
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed", receta.IdUniMed);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", receta.Status);
            return View(receta);
        }

        // POST: Recetas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdReceta,IdCategoria,Descripcion,Merma,IdUniMed,CostoKilo,Status,Observaciones")] Recetas receta)
        {
            if (id != receta.IdReceta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RecetasExists(receta.IdReceta))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", new { id = receta.IdReceta });
            }
            ViewData["IdCategoria"] = new SelectList(_context.Categorias, "IdCategoria", "NombreCategoria", receta.IdCategoria);
            ViewData["IdUniMed"] = new SelectList(_context.UnidadesMedida, "IdUniMed", "DescripcionUniMed", receta.IdUniMed);
            ViewData["Status"] = new SelectList(_context.Status, "Status1", "DescripcionStatus", receta.Status);
            return View(receta);
        }

        // GET: Recetas/Delete/5
        public async Task<IActionResult> Delete(int? id, String errorMessage)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receta = await _context.Recetas
                .Include(r => r.IdCategoriaNavigation)
                .Include(r => r.IdUniMedNavigation)
                .Include(r => r.StatusNavigation)
                .FirstOrDefaultAsync(m => m.IdReceta == id);
            if (receta == null)
            {
                return NotFound();
            }

            _context.Entry(receta).State = EntityState.Detached;
            ViewBag.ErrorMessage = errorMessage;
            return View(receta);
        }

        // POST: Recetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            try
            {
                var receta = await _context.Recetas.FindAsync(id);
                _context.Recetas.Remove(receta);
                await _context.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                String exceptionMessage = ex.Message;
                return RedirectToAction("Delete", new { idReceta = id, errorMessage = exceptionMessage });
            }
            
            return RedirectToAction(nameof(Index));
        }

        private bool RecetasExists(int id)
        {
            return _context.Recetas.Any(e => e.IdReceta == id);
        }
    }
}
