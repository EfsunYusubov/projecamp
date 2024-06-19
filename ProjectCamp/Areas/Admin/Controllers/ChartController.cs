using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectCamp.Areas.Admin.Models;
using System.Collections.Generic;

namespace ProjectCamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> List = new List<CategoryClass>();
            List.Add(new CategoryClass
            {
                categoryname = "Texnologiya",
                categorycount = 10
            });

            List.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14
            });

            List.Add(new CategoryClass
            {
                categoryname = "İdman",
                categorycount = 5
            });
            // Scriptler ucun
            return Json(new { jsonlist = List });

        }
    }
}
