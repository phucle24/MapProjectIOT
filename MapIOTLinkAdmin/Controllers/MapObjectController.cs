﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapIOTLinkAPI.Catalog;
using MapIOTLinkAPI.Models;
using MapIOTLinkAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace MapIOTLinkAdmin.Controllers
{
    public class MapObjectController : Controller
    {
        private readonly IMapApiClient _mapApiClient;
        private readonly IConfiguration _configuration;

        public MapObjectController(IMapApiClient mapApiClient, IConfiguration configuration)
        {
            _mapApiClient = mapApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index()
        {
            var result = await _mapApiClient.GetObjectsPaging();
            return Ok(result.ResultObj);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ObjectCreateRequest request)
        {
            if (!ModelState.IsValid)
                return View();

            var result = await _mapApiClient.CreateObject(request);

            if (result.IsSuccessed)
                return RedirectToAction("Index","Home");
            ModelState.AddModelError("", result.Message);
                return View(request);
        }
    }
}