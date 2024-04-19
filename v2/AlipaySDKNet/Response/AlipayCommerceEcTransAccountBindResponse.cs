using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcTransAccountBindResponse.
    /// </summary>
    public class AlipayCommerceEcTransAccountBindResponse : AopResponse
    {
        /// <summary>
        /// 授权签约链接
        /// </summary>
        [XmlElement("authorize_link")]
        public string AuthorizeLink { get; set; }
    }
}
