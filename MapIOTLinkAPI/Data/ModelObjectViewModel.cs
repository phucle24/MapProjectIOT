using MapIOTLinkAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Models
{
    public class ModelObjectViewModel
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public ObjectViewModel Result { get; set; }

    }
}
