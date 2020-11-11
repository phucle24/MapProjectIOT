using MapIOTLinkAPI.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAdmin.Services
{
    public interface IPlaceApiClient
    {
        Task<ApiResult<bool>> CreatePlace(PlaceCreateRequest request);
    }
}
