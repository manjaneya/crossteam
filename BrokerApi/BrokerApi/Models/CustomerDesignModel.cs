using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApii.Models
{
    /// <summary>
    /// CustomerDesignModel
    /// </summary>
    public class CustomerDesignModel
    {
        public Guid DesignSessionId { get; set; }
        public IEnumerable<CustomerDesigns> CustomerSelectedDesigns { get; set; }
        public string DesignSessionhGuid;
        public string StoreNumber;
        public string LanguageCode;
        public string ConfiguratorCode;
        public int CustomerOrderNumber;
        public string CustomerID;

    }
    
    public class CustomerDesigns
    {
        public string DesignName;
        public string DesignGuid;
        public string designData;
    }
}