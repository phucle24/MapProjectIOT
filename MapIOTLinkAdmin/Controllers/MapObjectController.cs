using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapIOTLinkAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace MapIOTLinkAdmin.Controllers
{
    public class MapObjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(MapObject request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await .RegisterUser(request);

            if (result.IsSuccessed)
                return RedirectToAction("Index");
            ModelState.AddModelError("", result.Message);
            return View(request);
        }
    }
}