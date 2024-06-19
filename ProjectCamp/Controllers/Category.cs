using BusinessLayer.Concrete;
using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProjectCamp.Controllers
{
    [AllowAnonymous]
    public class Category : Controller
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
