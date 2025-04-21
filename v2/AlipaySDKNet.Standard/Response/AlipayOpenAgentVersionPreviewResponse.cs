using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentVersionPreviewResponse.
    /// </summary>
    public class AlipayOpenAgentVersionPreviewResponse : AopResponse
    {
        /// <summary>
        /// 预览链接
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }
    }
}
