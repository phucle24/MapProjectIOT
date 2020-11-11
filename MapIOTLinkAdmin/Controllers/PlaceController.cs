using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapIOTLinkAdmin.Services;
using MapIOTLinkAPI.Catalog;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MapIOTLinkAdmin.Controllers
{
    public class PlaceController : Controller
    {
        private readonly IPlaceApiClient _placeApiClient;
        private readonly IConfiguration _configuration;

        public PlaceController(IPlaceApiClient placeApiClient, IConfiguration configuration)
        {
            _placeApiClient = placeApiClient;
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PlaceCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _placeApiClient.CreatePlace(request);

            if (result.IsSuccessed)
                return RedirectToAction("Index", "Home");
            ModelState.AddModelError("", result.Message);
            return View(request);
        }
    }
}