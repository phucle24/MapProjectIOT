﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.System
{
    public class PageResult<T>
    {
        public List<T> Items { get; set; }
    }
}
