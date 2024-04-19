using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcAuthorizationRedicturlGetResponse.
    /// </summary>
    public class AlipayCommerceEcAuthorizationRedicturlGetResponse : AopResponse
    {
        /// <summary>
        /// 企业端页面链接
        /// </summary>
        [XmlElement("redirect_url")]
        public string RedirectUrl { get; set; }
    }
}
