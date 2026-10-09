using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAgentVesionPreviewResponse.
    /// </summary>
    public class AlipayOpenAgentVesionPreviewResponse : AopResponse
    {
        /// <summary>
        /// 二维码预览链接
        /// </summary>
        [XmlElement("preview_url")]
        public string PreviewUrl { get; set; }
    }
}
