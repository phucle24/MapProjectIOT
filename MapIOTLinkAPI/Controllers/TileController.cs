using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapIOTLinkAPI.Models;
using MapIOTLinkAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MapIOTLinkAPI.Controllers
{
    [Route("api/tile")]
    [ApiController]
    public class TileController : Controller
    {
        private readonly TileService _tileService;
        public TileController(TileService tileService)
        {
            _tileService = tileService;
        }

        [HttpGet]
        public ActionResult<List<Tile>> Get() => _tileService.Get();

        [HttpPost]
        public IActionResult Create(Tile cliente)
        {
            _tileService.Create(cliente);

            return CreatedAtRoute("", new
            {
                id = cliente.Id.ToString()
            }, cliente);
        }
    }
}
