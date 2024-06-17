using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateComponentBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceTemplateComponentBatchqueryModel : AopObject
    {
        /// <summary>
        /// 模版编码列表
        /// </summary>
        [XmlArray("template_codes")]
        [XmlArrayItem("string")]
        public List<string> TemplateCodes { get; set; }

        /// <summary>
        /// 模板库编码
        /// </summary>
        [XmlElement("template_lib_code")]
        public string TemplateLibCode { get; set; }
    }
}
