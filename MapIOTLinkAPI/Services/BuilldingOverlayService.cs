using MapIOTLinkAPI.Data;
using MapIOTLinkAPI.Data.Configuration;
using MapIOTLinkAPI.Models;
using MapIOTLinkAPI.System;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Services
{
    public class BuilldingOverlayService
    {
        // Query : Join 2 bảng
        // Lọc
        // Kiểm tra request  === x - y - z
        // Return result

        private readonly IMongoCollection<ModelObject> _modelObjects;
        private readonly IMongoCollection<Tile> _modelTiles;
        public BuilldingOverlayService(IMapIOTDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _modelObjects = database.GetCollection<ModelObject>(settings.MapIOTDBCollectionName);
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
        public List<ModelObjectViewModel> GetAll(int x, int y, int z)
        {


            //1 . Lấy mảng objectId từ Tile
            var query = from p in _modelTiles.AsQueryable()
                        where p.X == x && p.Y == y && p.Zoom == z
                        select new ModelObjectViewModel()
                        {
                            Objects = p.Objects,
                        };
 /*           var query2 = from o in _modelObjects.AsQueryable()
                         where o.Id == "5f8d348116b657ed2dbbcdaa"
                         select o;
*/

            return query.ToList();
        }
    }
}
        