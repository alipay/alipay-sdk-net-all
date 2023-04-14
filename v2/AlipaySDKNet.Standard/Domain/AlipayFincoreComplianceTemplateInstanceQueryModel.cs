using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstanceQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceTemplateInstanceQueryModel : AopObject
    {
        /// <summary>
        /// 模版业务实例id
        /// </summary>
        [XmlElement("biz_instance_id")]
        public string BizInstanceId { get; set; }

        /// <summary>
        /// 系统来源
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }
    }
}
