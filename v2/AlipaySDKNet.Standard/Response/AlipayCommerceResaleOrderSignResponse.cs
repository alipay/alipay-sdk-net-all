using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceResaleOrderSignResponse.
    /// </summary>
    public class AlipayCommerceResaleOrderSignResponse : AopResponse
    {
        /// <summary>
        /// 信用受理台签约链接
        /// </summary>
        [XmlElement("zmxy_sign_url")]
        public string ZmxySignUrl { get; set; }
    }
}
