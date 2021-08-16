using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using EStoreApp.Web.Models.Domain;
using EStoreApp.Web.Models.Mapper;
using EStoreApp.Web.Models.ViewModels;
using System.Threading.Tasks;

namespace EStoreApp.Web.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<ProductDetailsViewModel> productViewList = new List<ProductDetailsViewModel>();

            StaticDB.Products.ForEach(x => productViewList.Add(x.ProductToProductDetailsViewmodel()));

            ViewData.Add("Title", "All Products");

            return View(productViewList);
        }

        public IActionResult Details(int id)
        {
            if (StaticDB.Products.Any(x => x.Id == id))
            {
                Product product = StaticDB.Products.SingleOrDefault(x => x.Id == id);

                ProductDetailsViewModel productView = product.ProductToProductDetailsViewmodel();

                ViewBag.Product = productView;

                ViewData.Add("Title", "Details for the chosen product");

                return View();
            }
            else
            {
                return RedirectToAction("Error", "Home");
            }
        }

        public IActionResult Promotion()
        {
            return View();
        }
    }
}
