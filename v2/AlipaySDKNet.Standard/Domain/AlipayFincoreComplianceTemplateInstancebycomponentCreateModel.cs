using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstancebycomponentCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceTemplateInstancebycomponentCreateModel : AopObject
    {
        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("biz_business_id")]
        public string BizBusinessId { get; set; }

        /// <summary>
        /// 组件实例列表
        /// </summary>
        [XmlArray("component_inst_dtos")]
        [XmlArrayItem("agm_component_instance_d_t_o")]
        public List<AgmComponentInstanceDTO> ComponentInstDtos { get; set; }

        /// <summary>
        /// 幂等值，如果幂等键已存在数据，则直接返回该数据，默认取业务单据号
        /// </summary>
        [XmlElement("idempotent")]
        public string Idempotent { get; set; }

        /// <summary>
        /// 来源系统id
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        [XmlArray("template_codes")]
        [XmlArrayItem("string")]
        public List<string> TemplateCodes { get; set; }

        /// <summary>
        /// 业务模板库编码
        /// </summary>
        [XmlElement("template_lib_code")]
        public string TemplateLibCode { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
