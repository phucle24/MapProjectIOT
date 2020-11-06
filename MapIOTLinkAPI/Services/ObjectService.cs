using MapIOTLinkAPI.Data.Configuration;
using MapIOTLinkAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public List<MapObject> Get()
        {
            List<MapObject> objects;
            objects = _modelObjects.Find(emp => true).ToList();
            return objects;
        }
        public MapObject GetbyId(string id) =>
          _modelObjects.Find(p => p.Id == id).FirstOrDefault();

        public MapObject Create(MapObject cli)
        {
            _modelObjects.InsertOne(cli);
            return cli;
        }
        public void Update(string id, MapObject model) =>
          _modelObjects.ReplaceOne(p => p.Id == id, model);

    }
}
