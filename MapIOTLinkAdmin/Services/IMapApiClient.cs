using MapIOTLinkAPI.Catalog;
using MapIOTLinkAPI.Data;
using MapIOTLinkAPI.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Services
{
    public interface IMapApiClient
    {
        Task<ApiResult<bool>> CreateObject(ObjectCreateRequest request);
        Task<ApiResult<PageResult<ObjectVM>>> GetObjectsPaging();

    }
}
