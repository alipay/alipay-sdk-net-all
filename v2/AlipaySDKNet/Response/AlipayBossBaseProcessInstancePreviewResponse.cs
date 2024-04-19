using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayBossBaseProcessInstancePreviewResponse.
    /// </summary>
    public class AlipayBossBaseProcessInstancePreviewResponse : AopResponse
    {
        /// <summary>
        /// 预演返回结果
        /// </summary>
        [XmlElement("preview_step")]
        public BPOpenApiInstancePreviewStep PreviewStep { get; set; }
    }
}
