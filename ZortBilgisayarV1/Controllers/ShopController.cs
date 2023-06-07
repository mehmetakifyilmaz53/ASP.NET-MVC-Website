using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ZortBilgisayarV1.business.Abstract;
using ZortBilgisayarV1.entity;
using ZortBilgisayarV1.ViewModels;

namespace ZortBilgisayarV1.Controllers
{
    public class ShopController : Controller
    {
        private IProductService _productService;

        public ShopController(IProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult List()
        {

            
            var ProductViewModel = new ProductListViewModel()
            {
                Products = _productService.Getall()
            };
            return View(ProductViewModel);
        }
        public IActionResult Details(int? id)
        {
            if (id==null)
            {
                return NotFound();
            }
            Product product = _productService.GetById((int)id);

            if (product==null)
            {
                return NotFound();
            }
            return View(product);
        }
    }

}