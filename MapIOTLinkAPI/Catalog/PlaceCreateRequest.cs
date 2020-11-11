using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Catalog
{
    public class PlaceCreateRequest
    {
        public string Name { get; set; }

        public double Longtitude { get; set; }

        public double Latitude { get; set; }

        public string TypeObject { get; set; }

        public string Lable { get; set; }

        public string Phone { get; set; }

        public int Rank { get; set; }

        public int Time { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public string Village { get; set; }

        public string Nest { get; set; }

        public string Street { get; set; }

        public string ApartmentNumber { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string Description { get; set; }

        public string ShortDescription { get; set; }
    }
}
