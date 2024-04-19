using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateMatchQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateMatchQueryResponse : AopResponse
    {
        /// <summary>
        /// 模版编码列表
        /// </summary>
        [XmlElement("template_codes")]
        public string TemplateCodes { get; set; }
    }
}
