using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcSupplierHomepageurlQueryResponse.
    /// </summary>
    public class AlipayCommerceEcSupplierHomepageurlQueryResponse : AopResponse
    {
        /// <summary>
        /// 供给首页链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
