using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEducateVerifyConsultResponse.
    /// </summary>
    public class AlipayCommerceEducateVerifyConsultResponse : AopResponse
    {
        /// <summary>
        /// 用于跳转验证的链接
        /// </summary>
        [XmlElement("normal_url")]
        public string NormalUrl { get; set; }

        /// <summary>
        /// 请求id，用于标识一次完整的验证请求链路
        /// </summary>
        [XmlElement("verify_request_id")]
        public string VerifyRequestId { get; set; }
    }
}
