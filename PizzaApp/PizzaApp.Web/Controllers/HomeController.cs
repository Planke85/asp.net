using Microsoft.AspNetCore.Mvc;
using PizzaApp.Domain.Models;
using PizzaApp.Services.Services.Interface;
using PizzaApp.Web.Models;
using System.Collections.Generic;

namespace PizzaApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private IPizzaOrderService _pizzaOrderService;

        public HomeController(IPizzaOrderService pizzaOrderService)
        {
            _pizzaOrderService = pizzaOrderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(HomeViewModel model)
        {
            return RedirectToAction("Order", "Order", new { pizzas = model.NumberOfPizzas });
        }

        public IActionResult Menu()
        {
            List<Pizza> menu = _pizzaOrderService.GetMenu();

            List<PizzaViewModel> pizzas = new List<PizzaViewModel>();

            foreach (var pizza in menu)
            {
                pizzas.Add(new PizzaViewModel
                {
                    Id = pizza.Id,
                    Name = pizza.Name,
                    Image = pizza.Image,
                    Price = pizza.Price,
                    PizzaSize = pizza.PizzaSize
                });
            }

            MenuViewModel model = new MenuViewModel
            {
                Pizzas = pizzas
            };

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is the about page for our pizza app!";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "You can find us here!";
            return View();
        }
    }
}
