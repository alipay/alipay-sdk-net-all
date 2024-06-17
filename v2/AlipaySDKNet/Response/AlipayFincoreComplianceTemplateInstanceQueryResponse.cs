using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstanceQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceTemplateInstanceQueryResponse : AopResponse
    {
        /// <summary>
        /// 对题结果
        /// </summary>
        [XmlElement("answers")]
        public AnswerDTO Answers { get; set; }

        /// <summary>
        /// 模版实例状态
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 返回的实例列表
        /// </summary>
        [XmlArray("template_instance_list")]
        [XmlArrayItem("template_inst_d_t_o")]
        public List<TemplateInstDTO> TemplateInstanceList { get; set; }

        /// <summary>
        /// 模版实例
        /// </summary>
        [XmlElement("template_instances")]
        public TemplateInstDTO TemplateInstances { get; set; }
    }
}
