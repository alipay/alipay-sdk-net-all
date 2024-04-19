using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayUserCertdocUrlQueryResponse.
    /// </summary>
    public class AlipayUserCertdocUrlQueryResponse : AopResponse
    {
        /// <summary>
        /// 链接
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }
    }
}
