using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Models
{
    public class Place
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("longtitude")]
        public double Longtitude { get; set; }

        [BsonElement("latitude")]
        public double Latitude { get; set; }

        [BsonElement("type")]
        public string TypeObject { get; set; }

        [BsonElement("lable")]
        public string Lable { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }
        
        [BsonElement("rank")]
        public int Rank { get; set; }

        [BsonElement("time")]
        public int Time { get; set; }

        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("province ")]
        public string Province { get; set; }

        [BsonElement("village")]
        public string Village { get; set; }

        [BsonElement("nest")]
        public string Nest { get; set; }

        [BsonElement("street")]
        public string Street { get; set; }

        [BsonElement("apartmentNumber")]
        public string ApartmentNumber { get; set; }

        [BsonElement("startDate ")]
        public DateTime StartDate { get; set; }

        [BsonElement("endDate")]
        public DateTime EndDate { get; set; }

        [BsonElement("description ")]
        public string Description { get; set; }

        [BsonElement("shortDescription ")]
        public string ShortDescription { get; set; }

    }
}
