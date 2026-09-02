using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOfflineMarketActivityProductSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOfflineMarketActivityProductSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("activities")]
        [XmlArrayItem("activity_sync_item")]
        public List<ActivitySyncItem> Activities { get; set; }
    }
}
