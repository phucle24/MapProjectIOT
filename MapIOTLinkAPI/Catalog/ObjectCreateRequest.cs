using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Catalog
{
    public class ObjectCreateRequest
    {
        public string ObjUrl { get; set; }

        public string TextureUrl { get; set; }

        public double Longtitude { get; set; }

        public double Latitude { get; set; }

        public int Scale { get; set; }

        public int Bearing { get; set; }

        public int Elevation { get; set; }

        public string Name { get; set; }

        public string TypeObject { get; set; }

        public int MinZoom { get; set; }

        public int MaxZoom { get; set; }
        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public string Information { get; set; }

        public string Typeinfor { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public int Acreage { get; set; }

        public string Village { get; set; }

        public string Nest { get; set; }

        public int Height { get; set; }

        public string Street { get; set; }
        public string ApartmentNumber { get; set; }

        public int FloorNummber { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
