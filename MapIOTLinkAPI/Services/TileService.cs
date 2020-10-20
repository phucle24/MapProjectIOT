using MapIOTLinkAPI.Data.Configuration;
using MapIOTLinkAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Services
{
    public class TileService
    {
        private readonly IMongoCollection<Tile> _modelTile;
        public TileService(IMapIOTDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _modelTile = database.GetCollection<Tile>(settings.MapIOTDBCollectionName2);

        }
        public List<Tile> Get()
        {
            List<Tile> tiles;
            tiles = _modelTile.Find(x => true).ToList();
            return tiles;
        }
        public Tile Create(Tile cli)
        {
            _modelTile.InsertOne(cli);
            return cli;
        }

    }
}
