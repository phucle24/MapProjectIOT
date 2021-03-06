﻿using MapIOTLinkAPI.Catalog;
using MapIOTLinkAPI.Data;
using MapIOTLinkAPI.System;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Services
{
    public class MapApiClient : IMapApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MapApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration,
                                 IHttpContextAccessor httpContextAccessor)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;

        }

        public async Task<ApiResult<bool>> CreateObject(ObjectCreateRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/api/objects", httpContent);
            var result = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<ApiSuccessResult<bool>>(result);
            }
            return JsonConvert.DeserializeObject<ApiErrorResult<bool>>(result);
        }
        public async Task<ApiResult<PageResult<ObjectVM>>> GetObjectsPaging()
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var response = await client.GetAsync($"/api/objects");
            var body = await response.Content.ReadAsStringAsync();
            var mapobject = JsonConvert.DeserializeObject<ApiSuccessResult<PageResult<ObjectVM>>>(body);
            return mapobject;
        }
    }
}
