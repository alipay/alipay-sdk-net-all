using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstanceQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateInstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 模版实例状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模版实例
        /// </summary>
        [XmlElement("template_instances")]
        public TemplateInstDTO TemplateInstances { get; set; }
    }
}
