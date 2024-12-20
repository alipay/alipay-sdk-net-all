using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BidResult Data Structure.
    /// </summary>
    [Serializable]
    public class BidResult : AopObject
    {
        /// <summary>
        /// 中标调整负荷
        /// </summary>
        [XmlArray("bid_adjustment")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> BidAdjustment { get; set; }

        /// <summary>
        /// 中标运行负荷
        /// </summary>
        [XmlArray("bid_load")]
        [XmlArrayItem("load_info_node")]
        public List<LoadInfoNode> BidLoad { get; set; }

        /// <summary>
        /// 中标价格
        /// </summary>
        [XmlArray("bid_price")]
        [XmlArrayItem("price_info_node")]
        public List<PriceInfoNode> BidPrice { get; set; }
    }
}
