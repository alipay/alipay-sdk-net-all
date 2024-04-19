using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenLotteryRegionCreateResponse.
    /// </summary>
    public class AlipayOpenLotteryRegionCreateResponse : AopResponse
    {
        /// <summary>
        /// 商家入驻ID
        /// </summary>
        [XmlElement("region_id")]
        public string RegionId { get; set; }
    }
}
