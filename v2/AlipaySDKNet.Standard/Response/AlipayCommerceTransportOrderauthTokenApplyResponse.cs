using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceTransportOrderauthTokenApplyResponse.
    /// </summary>
    public class AlipayCommerceTransportOrderauthTokenApplyResponse : AopResponse
    {
        /// <summary>
        /// 无需乱码，用来做用户授权
        /// </summary>
        [XmlElement("industry_auth_token")]
        public string IndustryAuthToken { get; set; }
    }
}
