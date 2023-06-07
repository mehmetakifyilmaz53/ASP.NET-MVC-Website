using Microsoft.AspNetCore.Mvc;
using ZortBilgisayarV1.entity;
using ZortBilgisayarV1.ViewModels;
using ZortBilgisayarV1.data;
using ZortBilgisayarV1.data.Abstract;
using ZortBilgisayarV1.business.Abstract;

namespace ZortBilgisayarV1.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;

        public HomeController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult index()
        {
            var ProductViewModel = new ProductListViewModel()
            {
                Products = _productService.Getall()
            };


            return View(ProductViewModel);


        }


        public IActionResult about()
        {
            return View();
        }
        public IActionResult contact()
        {
            return View();
        }


    }
}