using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayEbppInvoiceUserAuthQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceUserAuthQueryResponse : AopResponse
    {
        /// <summary>
        /// true：已授权 false：未授权
        /// </summary>
        [XmlElement("has_authorized")]
        public bool HasAuthorized { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 用户签约协议链接
        /// </summary>
        [XmlElement("protocol_url")]
        public string ProtocolUrl { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
