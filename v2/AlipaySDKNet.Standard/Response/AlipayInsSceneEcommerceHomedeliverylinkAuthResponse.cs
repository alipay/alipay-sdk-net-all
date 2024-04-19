using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayInsSceneEcommerceHomedeliverylinkAuthResponse.
    /// </summary>
    public class AlipayInsSceneEcommerceHomedeliverylinkAuthResponse : AopResponse
    {
        /// <summary>
        /// 行动点描述
        /// </summary>
        [XmlElement("action_desc")]
        public string ActionDesc { get; set; }

        /// <summary>
        /// 行动点副描述
        /// </summary>
        [XmlElement("action_sub_desc")]
        public string ActionSubDesc { get; set; }

        /// <summary>
        /// 授权token
        /// </summary>
        [XmlElement("authed_token")]
        public string AuthedToken { get; set; }

        /// <summary>
        /// 寄件url
        /// </summary>
        [XmlElement("authed_url")]
        public string AuthedUrl { get; set; }

        /// <summary>
        /// 寄件状态
        /// </summary>
        [XmlElement("delivery_status")]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [XmlElement("expiration")]
        public string Expiration { get; set; }

        /// <summary>
        /// 物流单摘要
        /// </summary>
        [XmlElement("logistics_digest")]
        public InsOpenLogisticsDigestDTO LogisticsDigest { get; set; }
    }
}
