using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web_DI.Models;
using Web_DI.Services;

namespace Web_DI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductService productService;
        private readonly IProductService productService1;

        public HomeController(IProductService productService, IProductService productService1)
        {
            this.productService  = productService;
            this.productService1 = productService1;
        }

        public IActionResult Index()
        {
            var p  = productService.GetProduct();
            var p1 = productService1.GetProduct();
            p.Name = $"{p.Id} กับ {p1.Id}";
            return View(p);
        }
    }

}