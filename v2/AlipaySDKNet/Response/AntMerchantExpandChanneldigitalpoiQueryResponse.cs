using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AntMerchantExpandChanneldigitalpoiQueryResponse.
    /// </summary>
    public class AntMerchantExpandChanneldigitalpoiQueryResponse : AopResponse
    {
        /// <summary>
        /// null
        /// </summary>
        [XmlArray("shop_info")]
        [XmlArrayItem("channel_shop")]
        public List<ChannelShop> ShopInfo { get; set; }
    }
}
