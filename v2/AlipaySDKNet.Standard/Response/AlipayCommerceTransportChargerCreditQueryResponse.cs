using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportChargerCreditQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportChargerCreditQueryResponse : AopResponse
    {
        /// <summary>
        /// 协议失效时间
        /// </summary>
        [XmlElement("invalid_time")]
        public string InvalidTime { get; set; }

        /// <summary>
        /// 协议当前状态。 注意：当前仅返回 NORMAL：（正常）状态。
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 协议生效时间
        /// </summary>
        [XmlElement("valid_time")]
        public string ValidTime { get; set; }
    }
}
