using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceTransportTourStockSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportTourStockSyncModel : AopObject
    {
        /// <summary>
        /// 景点Id
        /// </summary>
        [XmlElement("scenic_id")]
        public string ScenicId { get; set; }

        /// <summary>
        /// null
        /// </summary>
        [XmlArray("stock_info_list")]
        [XmlArrayItem("tour_stock_info")]
        public List<TourStockInfo> StockInfoList { get; set; }
    }
}
