using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTourOrderSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTourOrderSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("scene_codes")]
        [XmlArrayItem("string")]
        public List<string> SceneCodes { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("tour_order_list")]
        [XmlArrayItem("tour_order_sync_detail")]
        public List<TourOrderSyncDetail> TourOrderList { get; set; }
    }
}
