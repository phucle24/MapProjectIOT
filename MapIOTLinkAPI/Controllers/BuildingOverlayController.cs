using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapIOTLinkAPI.Models;
using MapIOTLinkAPI.Services;
using MapIOTLinkAPI.System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MapIOTLinkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingOverlayController : ControllerBase
    {
        private readonly BuilldingOverlayService _buildingOverlayService;

        public BuildingOverlayController(BuilldingOverlayService buildingOverlayService)
        {
            _buildingOverlayService = buildingOverlayService;
        }


        // http://localhost:port/api/z/x/y
        [HttpGet("{z}/{x}/{y}")]
        public ActionResult GetAll(int x, int y, int z) 
        {
            var result =  _buildingOverlayService.GetAll(x, y, z);
             return Ok(result);
        }

    }
}