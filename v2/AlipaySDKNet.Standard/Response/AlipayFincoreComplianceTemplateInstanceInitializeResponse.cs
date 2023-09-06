using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstanceInitializeResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateInstanceInitializeResponse : AopResponse
    {
        /// <summary>
        /// 业务唯一单据号
        /// </summary>
        [XmlElement("biz_business_id")]
        public string BizBusinessId { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 模板实例列表
        /// </summary>
        [XmlElement("template_instances")]
        public AgmTemplateInstanceDTO TemplateInstances { get; set; }
    }
}
