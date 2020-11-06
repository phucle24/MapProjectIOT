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
        public ActionResult<List<MapObject>> Get() => _objectService.Get();


        [HttpGet("{id}")]
        public ActionResult<MapObject> GetById(string id)
        {
            var modelObject = _objectService.GetbyId(id);

            if (modelObject == null)
            {
                return NotFound();
            }

            return modelObject;
        }

        [HttpPost]
        public IActionResult Create(MapObject cliente)
        {
            // Thêm object
            if (!ModelState.IsValid)
            {
                return BadRequest("Object không hợp lệ");
            }  
            _objectService.Create(cliente);
            
            // Thêm object thành công
            // Tính toán x - y - z  dựa vào lng - lat
            var x = (int)(Math.Floor((cliente.Location.Lng + 180.0) / 360.0 * (1 << cliente.MinZoom)));
            var y = (int)Math.Floor((1 - Math.Log(Math.Tan(ToRadians(cliente.Location.Lat)) + 1 / Math.Cos(ToRadians(cliente.Location.Lng))) / Math.PI) / 2 * (1 << cliente.MinZoom));
            // Kiểm tra xem nếu mà x - y - z == null thì thêm mới x - y - z đồng thời add id object

            // x-y-z đã == trong bảng tile thì chỉ việc update id object vào bảng tile
            
            return Ok();

        }

        private double ToRadians(double lng)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, MapObject mo)
        {
            var modelObject = _objectService.GetbyId(id);
            if(modelObject == null)
            {
                return BadRequest("Update không thành công");
            }
            _objectService.Update(id, mo);
            return Ok();
        }

    }
}