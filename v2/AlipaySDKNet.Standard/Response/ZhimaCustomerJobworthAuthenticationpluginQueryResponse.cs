using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCustomerJobworthAuthenticationpluginQueryResponse.
    /// </summary>
    public class ZhimaCustomerJobworthAuthenticationpluginQueryResponse : AopResponse
    {
        /// <summary>
        /// 用于端外直接跳转链接模式的Url入参
        /// </summary>
        [XmlElement("landing_url")]
        public string LandingUrl { get; set; }

        /// <summary>
        /// 用于直接跳转链接模式的Url入参
        /// </summary>
        [XmlElement("scheme_url")]
        public string SchemeUrl { get; set; }
    }
}
