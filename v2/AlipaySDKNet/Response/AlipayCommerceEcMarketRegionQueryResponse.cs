using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcMarketRegionQueryResponse.
    /// </summary>
    public class AlipayCommerceEcMarketRegionQueryResponse : AopResponse
    {
        /// <summary>
        /// 展区信息
        /// </summary>
        [XmlElement("region_info")]
        public OpenMarketingRegionDTO RegionInfo { get; set; }
    }
}
