using MapIOTLinkAPI.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Services
{
    public interface IPlaceService
    {
        Task<ApiResult<bool>> Create(PlaceCreateRequest request);
    }
}
