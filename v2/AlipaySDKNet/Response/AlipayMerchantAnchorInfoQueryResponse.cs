using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayMerchantAnchorInfoQueryResponse.
    /// </summary>
    public class AlipayMerchantAnchorInfoQueryResponse : AopResponse
    {
        /// <summary>
        /// 主播ID+唯一+天猫好房带货+根据uid获取
        /// </summary>
        [XmlElement("anchor_id")]
        public string AnchorId { get; set; }
    }
}
