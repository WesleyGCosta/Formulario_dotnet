using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class AutorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(AutorViewModel model)
        {
            if(ModelState.IsValid)
            {
                var autor = model;
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}
