using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Models
{
    public class Model
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }

        [BsonElement("type")]
        public string Type { get; set; }

        [BsonElement("objName")]
        public string ObjName { get; set; }

        [BsonElement("objUrl")]
        public string ObjUrl { get; set; }

        [BsonElement("textureName")]
        public string TextureName { get; set; }
        
        [BsonElement("textureUrl")]
        public string TextureUrl { get; set; }

        [BsonElement("color")]
        public string Color { get; set; }

        [BsonElement("height")]
        public int Height { get; set; }

        [BsonElement("coordinates")]

        public IList<Coordinate> Coordinates { get; set; }
    }
}
