using MapIOTLinkAPI.Catalog;
using MapIOTLinkAPI.Data.Configuration;
using System.Linq;
using MapIOTLinkAPI.Models;
using MapIOTLinkAPI.System;
using MongoDB.Driver;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MapIOTLinkAPI.Services
{
    public class ObjectService
    {

        private readonly IMongoCollection<MapObject> _modelObjects;
        public ObjectService(IMapIOTDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _modelObjects = database.GetCollection<MapObject>(settings.MapIOTDBCollectionName);

        }

        public async Task<ApiResult<PageResult<ObjectVM>>> GetObject  ()
        {
            var query = await _modelObjects.Find(x => true).FirstOrDefaultAsync();
            return null;
        }
        public MapObject GetbyId(string id) =>
          _modelObjects.Find(p => p.Id == id).FirstOrDefault();

        public async Task<ApiResult<bool>> Create(ObjectCreateRequest request)
        {
            var mapObject = new MapObject()
            {
                ObjUrl = request.ObjUrl,
                TextureUrl = request.TextureUrl,
                Longtitude = request.Longtitude,
                Latitude = request.Latitude,
                Scale = request.Scale,
                Bearing = request.Bearing,
                Elevation = request.Elevation,
                Name = request.Name,
                TypeObject = request.TypeObject,
                MinZoom = request.MinZoom,
                MaxZoom = request.MaxZoom,
                ShortDescription = request.ShortDescription,
                Description = request.Description,
                Information = request.Information,
                Typeinfor = request.Typeinfor,
                City = request.City,
                Province = request.Province,
                Acreage = request.Acreage,
                Village = request.Village,
                Nest = request.Nest,
                Height = request.Height,
                Street = request.Street,
                ApartmentNumber = request.ApartmentNumber,
                FloorNummber = request.FloorNummber,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
            };
            _modelObjects.InsertOne(mapObject);
            return new ApiSuccessResult<bool>();
        }
        public void Update(string id, MapObject model) =>
          _modelObjects.ReplaceOne(p => p.Id == id, model);

    }
}
