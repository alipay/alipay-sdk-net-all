using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTaxiDriverinfoModifyResponse.
    /// </summary>
    public class AlipayCommerceTransportTaxiDriverinfoModifyResponse : AopResponse
    {
        /// <summary>
        /// 状态码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 响应描述信息
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }
    }
}
