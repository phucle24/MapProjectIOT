using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MapIOTLinkAPI.Catalog;
using MapIOTLinkAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace MapIOTLinkAPI.Controllers
{
    [Route("api/places")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly IPlaceService _placeService;
        public PlaceController(IPlaceService placeService)
        {
            _placeService = placeService;
        }
        /*
                [HttpGet]
                public ActionResult<List<Place>> Get() => _placeService.Get();*/

        /*
                [HttpGet("{id}")]
                public ActionResult<Place> GetById(string id)
                {
                    var place = _placeService.GetbyId(id);

                    if (place == null)
                    {
                        return NotFound();
                    }

                    return place;
                }*/

        [HttpPost]
        public async Task<ActionResult> Create([FromBody]PlaceCreateRequest request)
        {
            // Thêm object
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _placeService.Create(request);

            return Ok(result);

        }
        /*
                [HttpPut("{id}")]
                public IActionResult Update(string id, Place pl)
                {
                    var place = _placeService.GetbyId(id);
                    if (place == null)
                    {
                        return BadRequest("Update không thành công");
                    }
                    _placeService.Update(id, pl);
                    return Ok();
                }*/

    }
}