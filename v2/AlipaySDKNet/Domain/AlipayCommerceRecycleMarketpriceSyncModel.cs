using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceRecycleMarketpriceSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceRecycleMarketpriceSyncModel : AopObject
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("market_price_list")]
        [XmlArrayItem("recycle_market_price_create_request")]
        public List<RecycleMarketPriceCreateRequest> MarketPriceList { get; set; }
    }
}
