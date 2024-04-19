using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateTemplatePreviewModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceTemplateTemplatePreviewModel : AopObject
    {
        /// <summary>
        /// 模版编码列表
        /// </summary>
        [XmlArray("template_codes")]
        [XmlArrayItem("string")]
        public List<string> TemplateCodes { get; set; }
    }
}
