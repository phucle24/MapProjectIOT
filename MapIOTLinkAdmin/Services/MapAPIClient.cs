using MapIOTLinkAPI.Data;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MapIOTLinkAdmin.Services
{
    public class MapAPIClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public MapAPIClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;

        }   
        public async Task Create()
        {
            await Http.PostAsJsonAsync
           
        }
    }
}
