using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportVehicleownerCampaignQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportVehicleownerCampaignQueryResponse : AopResponse
    {
        /// <summary>
        /// 活动信息
        /// </summary>
        [XmlElement("market_info")]
        public MarketInfo MarketInfo { get; set; }
    }
}
