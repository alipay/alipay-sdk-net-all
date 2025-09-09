using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayCommerceEcSupplierUrlQueryResponse.
    /// </summary>
    public class AlipayCommerceEcSupplierUrlQueryResponse : AopResponse
    {
        /// <summary>
        /// 供给跳链或者签约跳链，由url_type决定
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// 跳链类型
        /// </summary>
        [XmlElement("url_type")]
        public string UrlType { get; set; }
    }
}
