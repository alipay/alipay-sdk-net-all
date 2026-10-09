using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipaySecurityProdTemplateVersionPublishResponse.
    /// </summary>
    public class AlipaySecurityProdTemplateVersionPublishResponse : AopResponse
    {
        /// <summary>
        /// 发布结果
        /// </summary>
        [XmlElement("publish_result")]
        public bool PublishResult { get; set; }
    }
}
