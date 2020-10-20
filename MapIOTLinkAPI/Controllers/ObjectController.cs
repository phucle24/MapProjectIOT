using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapIOTLinkAPI.Models;
using MapIOTLinkAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MapIOTLinkAPI.Controllers
{
    [Route("api/objects")]
    [ApiController]
    public class ObjectController : ControllerBase
    {
        private readonly ObjectService _objectService;
        public ObjectController(ObjectService objectService)
        {
            _objectService = objectService;
        }

        [HttpGet]
        public ActionResult<List<ModelObject>> Get() => _objectService.Get();

        [HttpPost]
        public IActionResult Create(ModelObject cliente)
        {
            _objectService.Create(cliente);

            return CreatedAtRoute("", new
            {
                id = cliente.Id.ToString()
            }, cliente);
        }

    }
}