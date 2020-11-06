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


        // http://localhost:port/api/BuilldingOverlay/z/x/y
        [HttpGet("{z}/{x}/{y}")]
        public async Task<ModelObjectViewModel> GetAll(int x, int y, int z) 
        {
            var result = await _buildingOverlayService.GetAll(x, y, z);
             return result;
        }

    }
}