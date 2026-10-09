using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateComponentBatchqueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateComponentBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 模板组件列表
        /// </summary>
        [XmlArray("template_component_list_response_list")]
        [XmlArrayItem("template_component_list_response")]
        public List<TemplateComponentListResponse> TemplateComponentListResponseList { get; set; }
    }
}
