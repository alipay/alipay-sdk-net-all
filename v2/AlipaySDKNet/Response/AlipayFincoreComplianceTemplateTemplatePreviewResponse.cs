using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateTemplatePreviewResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateTemplatePreviewResponse : AopResponse
    {
        /// <summary>
        /// 模板预览列表
        /// </summary>
        [XmlArray("template_preview_response")]
        [XmlArrayItem("template_preview_response")]
        public List<TemplatePreviewResponse> TemplatePreviewResponse { get; set; }
    }
}
