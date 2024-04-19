using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateTemplateBatchqueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateTemplateBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 模板列表
        /// </summary>
        [XmlArray("template_new_models")]
        [XmlArrayItem("template_new_model_d_t_o")]
        public List<TemplateNewModelDTO> TemplateNewModels { get; set; }
    }
}
