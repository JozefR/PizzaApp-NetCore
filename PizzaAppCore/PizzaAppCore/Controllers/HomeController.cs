using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PizzaAppCore.Models;
using PizzaAppCore.ViewModels;
using System.Linq;

namespace PizzaAppCore.Controllers
{
    public class HomeController : Controller
    {
        private PizzaAppContext _context;

        public HomeController(PizzaAppContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var customer = new ViewModels.OrderFormViewModel
            {
                CustomerModel = new CustomerModel()
            };

            return View("Index", customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Save(CustomerModel customerModel, PizzaModel pizzaModel, ExtraIngredientsModel extraIngredients)
        {
            if (!ModelState.IsValid)
            {
                var customerViewModel = new OrderFormViewModel
                {
                    CustomerModel = customerModel,
                    PizzaModel = pizzaModel,
                    ExtraIngredients = extraIngredients
                };
                return View("Index", customerViewModel);
            }

            if (customerModel.ID == 0)
            {
                _context.Customer.Add(customerModel);
                _context.Pizza.Add(pizzaModel);
                _context.ExtraIngredients.Add(extraIngredients);
            }
                
            else
            {
                var customerInDb = _context.Customer.Single(c => c.ID == customerModel.ID);

                customerInDb.Name = customerModel.Name;
                customerInDb.Address = customerModel.Address;
                customerInDb.Phone = customerModel.Phone;

                _context.Pizza.Add(pizzaModel);
                _context.ExtraIngredients.Add(extraIngredients);
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "CustomerModels");

        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
