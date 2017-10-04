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
    public class OrderModelsController : Controller
    {
        private readonly PizzaAppContext _context;

        public OrderModelsController(PizzaAppContext context)
        {
            _context = context;
        }

        // GET: OrderModels
        public async Task<IActionResult> Index()
        {
            var pizzaAppContext = _context.Order.Include(o => o.CustomerModel);
            return View(await pizzaAppContext.ToListAsync());
        }

        // GET: OrderModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderModel = await _context.Order
                .Include(o => o.CustomerModel)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (orderModel == null)
            {
                return NotFound();
            }

            return View(orderModel);
        }

        // GET: OrderModels/Create
        public IActionResult Create()
        {
            ViewData["CustomerModelID"] = new SelectList(_context.Customer, "ID", "ID");
            return View();
        }

        // POST: OrderModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,OrderDate,OrderStatusEnum,TotalCost,Note,CustomerModelID")] OrderModel orderModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerModelID"] = new SelectList(_context.Customer, "ID", "ID", orderModel.CustomerModelID);
            return View(orderModel);
        }

        // GET: OrderModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderModel = await _context.Order.SingleOrDefaultAsync(m => m.ID == id);
            if (orderModel == null)
            {
                return NotFound();
            }
            ViewData["CustomerModelID"] = new SelectList(_context.Customer, "ID", "ID", orderModel.CustomerModelID);
            return View(orderModel);
        }

        // POST: OrderModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,OrderDate,OrderStatusEnum,TotalCost,Note,CustomerModelID")] OrderModel orderModel)
        {
            if (id != orderModel.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderModelExists(orderModel.ID))
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
            ViewData["CustomerModelID"] = new SelectList(_context.Customer, "ID", "ID", orderModel.CustomerModelID);
            return View(orderModel);
        }

        // GET: OrderModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderModel = await _context.Order
                .Include(o => o.CustomerModel)
                .SingleOrDefaultAsync(m => m.ID == id);
            if (orderModel == null)
            {
                return NotFound();
            }

            return View(orderModel);
        }

        // POST: OrderModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderModel = await _context.Order.SingleOrDefaultAsync(m => m.ID == id);
            _context.Order.Remove(orderModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderModelExists(int id)
        {
            return _context.Order.Any(e => e.ID == id);
        }
    }
}
