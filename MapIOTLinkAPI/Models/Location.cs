using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Models
{
    public class Location
    {
        [BsonElement("lng")]
        public double Lng { get; set; }

        [BsonElement("lat")]
        public double Lat { get; set; }
    }
}
