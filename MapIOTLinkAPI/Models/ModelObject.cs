using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Models
{
    public class ModelObject
    {
        [BsonId]
        [BsonRepresentation(BsonType.String)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("scale")]
        public int Scale { get; set; }

        [BsonElement("bearing")]
        public int Bearing { get; set; }

        [BsonElement("elevation")]
        public int Elevation { get; set; }

        [BsonElement("minZoom")]
        public int MinZoom { get; set; }

        [BsonElement("maxZoom")]
        public int MaxZoom { get; set; }

        [BsonElement("startDate")]
        public DateTime StartDate { get; set; }

        [BsonElement("endDate")]
        public DateTime EndtDate { get; set; }

        [BsonElement("model")]
        public Model Model{ get; set; }

        [BsonElement("camera")]
        public Camera Camera{ get; set; }

        [BsonElement("location")]
        public Location Location { get; set; }

        [BsonElement("types")]
        public string Type { get; set; }
    }
}
