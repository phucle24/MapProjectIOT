using MapIOTLinkAPI.Catalog;
using MapIOTLinkAPI.Data.Configuration;
using MapIOTLinkAPI.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Services
{
    public class PlaceService : IPlaceService
    {
        private readonly IMongoCollection<Place> _place;
        public PlaceService(IMapIOTDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _place = database.GetCollection<Place>(settings.MapIOTDBCollectionNamePlace);

        }

        public List<Place> Get()
        {
            List<Place> places;
            places = _place.Find(emp => true).ToList();
            return places;
        }
        public Place GetbyId(string id) =>
          _place.Find(p => p.Id == id).FirstOrDefault();


        public async Task<ApiResult<bool>> Create(PlaceCreateRequest request)
        {
            var place = new Place()
            {
                Name = request.Name,
                Longtitude = request.Longtitude,
                Latitude = request.Latitude,
                TypeObject = request.TypeObject,
                Lable = request.Lable,
                Phone = request.Phone,
                Rank = request.Rank,
                Time = request.Time,
                City = request.City,
                Province = request.Province,
                Village = request.Village,
                Nest = request.Nest,
                Street = request.Street,
                ApartmentNumber = request.ApartmentNumber,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                ShortDescription = request.ShortDescription,
                Description = request.Description,
            };
             _place.InsertOne(place);
            return new ApiSuccessResult<bool>();
        }
        public void Update(string id, Place place) =>
          _place.ReplaceOne(p => p.Id == id, place);

    }
}
