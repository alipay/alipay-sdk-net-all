using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportOrderauthQueryResponse.
    /// </summary>
    public class AlipayCommerceTransportOrderauthQueryResponse : AopResponse
    {
        /// <summary>
        /// 授权状态
        /// </summary>
        [XmlElement("auth_status")]
        public string AuthStatus { get; set; }
    }
}
