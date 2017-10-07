using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PizzaAppCore.Models;

namespace PizzaAppCore.Controllers
{
    public class ExtraIngredientsModelsController : Controller
    {
        private readonly PizzaAppContext _context;

        public ExtraIngredientsModelsController(PizzaAppContext context)
        {
            _context = context;
        }

        // GET: ExtraIngredientsModels
        public async Task<IActionResult> Index()
        {
            var pizzaAppContext = _context.ExtraIngredients;
            return View(await pizzaAppContext.ToListAsync());
        }

        // GET: ExtraIngredientsModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extraIngredientsModel = await _context.ExtraIngredients
                .SingleOrDefaultAsync(m => m.ID == id);
            if (extraIngredientsModel == null)
            {
                return NotFound();
            }

            return View(extraIngredientsModel);
        }

        // GET: ExtraIngredientsModels/Create
        public IActionResult Create()
        {
            ViewData["PizzaModelID"] = new SelectList(_context.Pizza, "ID", "ID");
            return View();
        }

        // POST: ExtraIngredientsModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Chcees,Pepperoni,Onions,Bacon,Sausage,PizzaModelID")] ExtraIngredientsModel extraIngredientsModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(extraIngredientsModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PizzaModelID"] = new SelectList(_context.Pizza, "ID", "ID");
            return View(extraIngredientsModel);
        }

        // GET: ExtraIngredientsModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extraIngredientsModel = await _context.ExtraIngredients.SingleOrDefaultAsync(m => m.ID == id);
            if (extraIngredientsModel == null)
            {
                return NotFound();
            }
            ViewData["PizzaModelID"] = new SelectList(_context.Pizza, "ID", "ID");
            return View(extraIngredientsModel);
        }

        // POST: ExtraIngredientsModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Chcees,Pepperoni,Onions,Bacon,Sausage,PizzaModelID")] ExtraIngredientsModel extraIngredientsModel)
        {
            if (id != extraIngredientsModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(extraIngredientsModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExtraIngredientsModelExists(extraIngredientsModel.ID))
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
            ViewData["PizzaModelID"] = new SelectList(_context.Pizza, "ID", "ID");
            return View(extraIngredientsModel);
        }

        // GET: ExtraIngredientsModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var extraIngredientsModell = await _context.ExtraIngredients
                .SingleOrDefaultAsync(m => m.ID == id);
            if (extraIngredientsModell == null)
            {
                return NotFound();
            }

                return View(extraIngredientsModell);
        }

        // POST: ExtraIngredientsModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var extraIngredientsModel = await _context.ExtraIngredients.SingleOrDefaultAsync(m => m.ID == id);
            _context.ExtraIngredients.Remove(extraIngredientsModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExtraIngredientsModelExists(int id)
        {
            return _context.ExtraIngredients.Any(e => e.ID == id);
        }
    }
}
