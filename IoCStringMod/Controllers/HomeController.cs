using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IoCStringMod.Models;
using IoCStringMod.BusinessLogic;


namespace IoCStringMod.Controllers
{
    public class HomeController : Controller
    {
        private ITextModifier mod;

        public HomeController(ITextModifier textmod)
        {
            mod = textmod;
        }
        public IActionResult Index()
        {
            var model = mod.ModifyText();
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
