using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportTourTokenExchangeResponse.
    /// </summary>
    public class AlipayCommerceTransportTourTokenExchangeResponse : AopResponse
    {
        /// <summary>
        /// 支付授权码
        /// </summary>
        [XmlElement("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 支付凭证类型
        /// </summary>
        [XmlElement("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 支付凭证实效时间
        /// </summary>
        [XmlElement("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 支付凭证启动时间
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
