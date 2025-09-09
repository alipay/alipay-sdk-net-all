using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantGroupGroupgiftQueryResponse.
    /// </summary>
    public class AlipayMerchantGroupGroupgiftQueryResponse : AopResponse
    {
        /// <summary>
        /// 多渠道入群有礼
        /// </summary>
        [XmlElement("multi_channel_join_gift")]
        public MultiChannelJoinGiftVO MultiChannelJoinGift { get; set; }
    }
}
