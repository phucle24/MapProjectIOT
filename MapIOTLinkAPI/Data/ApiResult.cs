using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Data
{
    public class ApiResult<T>
    {
        public bool IsSuccessed { get; set; }
        public string Message { get; set; }
        public T ResultObj { get; set; }
    }
}
