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

        private readonly IMongoCollection<ModelObject> _modelObjects;
        public ObjectService(IMapIOTDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _modelObjects = database.GetCollection<ModelObject>(settings.MapIOTDBCollectionName);

        }

        public List<ModelObject> Get()
        {
            List<ModelObject> objects;
            objects = _modelObjects.Find(emp => true).ToList();
            return objects;
        }

        public ModelObject Create(ModelObject cli)
        {
            _modelObjects.InsertOne(cli);
            return cli;
        }
    }
}
