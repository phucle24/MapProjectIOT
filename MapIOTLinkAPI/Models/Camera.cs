using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Models
{
    public class Camera
    {
        [BsonElement("zoom")]
        public int Zoom { get; set; }
        [BsonElement("brearing")]
        public int Brearing { get; set; }
        [BsonElement("tilt")]
        public int Tilt { get; set; }
    }
}
