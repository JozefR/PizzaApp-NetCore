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
    public class PizzaModelsController : Controller
    {
        private readonly PizzaAppContext _context;

        public PizzaModelsController(PizzaAppContext context)
        {
            _context = context;
        }

        // GET: PizzaModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pizza.ToListAsync());
        }

        // GET: PizzaModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaModel = await _context.Pizza
                .SingleOrDefaultAsync(m => m.ID == id);
            if (pizzaModel == null)
            {
                return NotFound();
            }

            return View(pizzaModel);
        }

        // GET: PizzaModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PizzaModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,PizaNameEnum,CrustEnum,SizeEnum,ExtraIngredientsModelID,OrderId")] PizzaModel pizzaModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pizzaModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pizzaModel);
        }

        // GET: PizzaModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaModel = await _context.Pizza.SingleOrDefaultAsync(m => m.ID == id);
            if (pizzaModel == null)
            {
                return NotFound();
            }
            return View(pizzaModel);
        }

        // POST: PizzaModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,PizaNameEnum,CrustEnum,SizeEnum,ExtraIngredientsModelID,OrderId")] PizzaModel pizzaModel)
        {
            if (id != pizzaModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pizzaModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PizzaModelExists(pizzaModel.ID))
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
            return View(pizzaModel);
        }

        // GET: PizzaModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizzaModel = await _context.Pizza
                .SingleOrDefaultAsync(m => m.ID == id);
            if (pizzaModel == null)
            {
                return NotFound();
            }

            return View(pizzaModel);
        }

        // POST: PizzaModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pizzaModel = await _context.Pizza.SingleOrDefaultAsync(m => m.ID == id);
            _context.Pizza.Remove(pizzaModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PizzaModelExists(int id)
        {
            return _context.Pizza.Any(e => e.ID == id);
        }
    }
}
