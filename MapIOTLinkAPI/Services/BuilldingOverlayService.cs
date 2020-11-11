using MapIOTLinkAPI.Data;
using MapIOTLinkAPI.Data.Configuration;
using MapIOTLinkAPI.Models;
using MapIOTLinkAPI.System;
using Microsoft.AspNetCore.Cors;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Services
{
    [EnableCors("CorsPolicy")]
    public class BuilldingOverlayService
    {
        private readonly IMongoCollection<MapObject> _modelObjects;
        private readonly IMongoCollection<Tile> _modelTiles;
        public BuilldingOverlayService(IMapIOTDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _modelObjects = database.GetCollection<MapObject>(settings.MapIOTDBCollectionName);
            _modelTiles = database.GetCollection<Tile>("Tiles");

        }

        /*  public async Task<IEnumerable<ModelObject>> GetAll(MapRequest request)
          {
              //1 . Join
              var query = from p in _modelTile.AsQueryable()
                          join pt in _modelObjects.AsQueryable() on p.ObjectId equals pt.Id
                          where p.X == request.x && p.Y == request.y && p.Zoom == request.z
                          select new { p, pt };
              var result = await _modelObjects.Find(_ => true).ToListAsync();
              return result;
          }*/
        public async Task<ModelObjectViewModel> GetAll(int x, int y, int z)
        {
            // Cách 1

            /*
           var query = from p in _modelTiles.AsQueryable()
                       where p.X == x && p.Y == y && p.Zoom == z
                       select p.Id;
           var query2 = query.ToString();

           var tile = await _modelTiles.Find(e => e.Id == query2).FirstOrDefaultAsync();

           */

            // Cách 2
            //1 . Lấy danh sách objectId từ Tile
            var tile = await _modelTiles.Find(e => e.Y == y && e.X == x && e.Zoom == z).FirstOrDefaultAsync();
            if(tile == null)
            {
                return new ModelObjectViewModel
                {
                    Code = "Ok",
                    Message = "",
                    Result = new ObjectViewModel
                    {
                        Objects = null
                    }
                };
            }
            // Khởi tạo List objects
            List<MapObject> objects = new List<MapObject>();

            //2. Lọc object với Id đã có
            foreach (var item in tile.Objects)
            {
                var result = _modelObjects.Find(p => p.Id == item).FirstOrDefault();
                objects.Add(result);
            }
                return new ModelObjectViewModel
                {
                    Code = "Ok",
                    Message = "",
                    Result = new ObjectViewModel
                    {
                        Objects = objects
                    }
                };
            
        }
    }
}
        