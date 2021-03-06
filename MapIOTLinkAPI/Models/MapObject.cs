﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Models
{
    public class MapObject
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("objUrl")]
        public string ObjUrl { get; set; }

        [BsonElement("textureUrl")]
        public string TextureUrl { get; set; }

        [BsonElement("longtitude")]
        public double Longtitude { get; set; }

        [BsonElement("latitude")]
        public double Latitude { get; set; }
        [BsonElement("scale")]
        public int Scale { get; set; }

        [BsonElement("bearing")]
        public int Bearing { get; set; }

        [BsonElement("elevation")]
        public int Elevation { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("type")]
        public string TypeObject { get; set; }

        [BsonElement("minZoom")]
        public int MinZoom { get; set; }

        [BsonElement("maxZoom")]
        public int MaxZoom { get; set; }
        [BsonElement("shortDescription ")]
        public string ShortDescription { get; set; }

        [BsonElement("description ")]
        public string Description { get; set; }

        [BsonElement("information")]
        public string Information { get; set; }

        [BsonElement("typeinfor")]
        public string Typeinfor { get; set; }

        [BsonElement("city")]
        public string City { get; set; }

        [BsonElement("province ")]
        public string Province { get; set; }

        [BsonElement("acreage ")]
        public int Acreage { get; set; }

        [BsonElement("village")]
        public string Village { get; set; }

        [BsonElement("nest")]
        public string Nest { get; set; }

        [BsonElement("height ")]
        public int Height { get; set; }

        [BsonElement("street")]
        public string Street { get; set; }

        [BsonElement("apartmentNumber")]
        public string ApartmentNumber { get; set; }

        [BsonElement("floorNummber ")]
        public int FloorNummber { get; set; }

        [BsonElement("startDate ")]
        public DateTime StartDate { get; set; }

        [BsonElement("endDate")]
        public DateTime EndDate { get; set; }

    }
}
