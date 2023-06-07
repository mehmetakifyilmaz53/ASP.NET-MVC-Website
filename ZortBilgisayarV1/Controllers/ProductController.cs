using Microsoft.AspNetCore.Mvc;
using ZortBilgisayarV1.entity;
using ZortBilgisayarV1.ViewModels;
using ZortBilgisayarV1.data;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ZortBilgisayarV1.Controllers
{
    public class ProductController : Controller
    {
         public IActionResult index()
        {
            return View();
        }

        public IActionResult list(int? id, string q)
        {
             

            return View();
        }

        public IActionResult categorylist()
        {
            return View();
        }
        public IActionResult details(int id)
        {
            return View();
        }
         public IActionResult hazırsistem()
        {
            return View();
        }
        public IActionResult tablet()
        {
            return View();
        }
        public IActionResult telefon()
        {
            return View();
        }

        // [HttpGet]
        // public IActionResult create()
        // {
        //     ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
        //     return View();
        // }

        // [HttpPost]
        // public IActionResult create_add(Product p)
        // {
        //     ProductRepository.AddProduct(p);
        //     return RedirectToAction("list");
        // }

        // [HttpGet]
        // public IActionResult edit(int id)
        // {
        //     ViewBag.Categories = new SelectList(CategoryRepository.Categories,"CategoryId","Name");
        //     return View(ProductRepository.GetProductById(id));
        // }
        // [HttpPost]
        // public IActionResult edit_product(Product p)
        // {
        //     ProductRepository.EditProduct(p);
        //     return RedirectToAction("list");
        // }

        // [HttpGet]
        // public IActionResult delete(int id)
        // {
        //     ViewBag.Name = new SelectList(ProductRepository.Products,"ProductId","Name");
        //     return View(ProductRepository.GetProductById(id));
        // }
        // [HttpPost]
        // public IActionResult edit_delete(Product p)
        // {
        //     ProductRepository.DeleteProduct(p);
        //     return RedirectToAction("list");
        // }
    }
}