using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MapIOTLinkAPI.Data.Configuration
{
    public class MapIOTDatabaseSettings : IMapIOTDatabaseSettings
    {
        public string MapIOTDBCollectionName { get; set;}
        public string ConnectionString { get ; set; }
        public string DatabaseName { get ; set ; }
        public string MapIOTDBCollectionName2 { get ; set; }
    }
}
