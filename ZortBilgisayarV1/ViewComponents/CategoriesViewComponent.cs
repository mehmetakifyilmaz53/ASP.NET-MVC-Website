using Microsoft.AspNetCore.Mvc;
using ZortBilgisayarV1.entity;
using ZortBilgisayarV1.data;
using ZortBilgisayarV1.business.Abstract;

namespace ZortBilgisayarV1.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;

        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
      
            ViewBag.SelectedCategory = RouteData.Values["id"];
            return View(_categoryService.GetAll());
            
        }
    }
}