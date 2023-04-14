using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateMatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceTemplateMatchQueryModel : AopObject
    {
        /// <summary>
        /// 业务要素
        /// </summary>
        [XmlElement("biz_object_def_json")]
        public string BizObjectDefJson { get; set; }

        /// <summary>
        /// 系统来源
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 模版库编码
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
