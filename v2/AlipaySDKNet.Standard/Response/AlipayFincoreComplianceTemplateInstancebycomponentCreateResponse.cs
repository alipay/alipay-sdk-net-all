using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstancebycomponentCreateResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateInstancebycomponentCreateResponse : AopResponse
    {
        /// <summary>
        /// 业务单据号
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
        [XmlArray("template_instances")]
        [XmlArrayItem("agm_template_instance_d_t_o")]
        public List<AgmTemplateInstanceDTO> TemplateInstances { get; set; }
    }
}
