using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeRoyaltyRateQueryResponse.
    /// </summary>
    public class AlipayTradeRoyaltyRateQueryResponse : AopResponse
    {
        /// <summary>
        /// 最大分账比例，百分比整数，取值范围0～100
        /// </summary>
        [XmlElement("max_ratio")]
        public long MaxRatio { get; set; }

        /// <summary>
        /// 当前商户userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
