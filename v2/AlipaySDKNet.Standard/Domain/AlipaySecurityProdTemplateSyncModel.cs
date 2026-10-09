using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdTemplateSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdTemplateSyncModel : AopObject
    {
        /// <summary>
        /// 操作人工号
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_system_id")]
        public string SourceSystemId { get; set; }

        /// <summary>
        /// 来源模板code
        /// </summary>
        [XmlElement("source_template_code")]
        public string SourceTemplateCode { get; set; }

        /// <summary>
        /// 来源模板库code
        /// </summary>
        [XmlElement("source_template_lib_code")]
        public string SourceTemplateLibCode { get; set; }

        /// <summary>
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 目标模板code
        /// </summary>
        [XmlElement("tgt_template_code")]
        public string TgtTemplateCode { get; set; }

        /// <summary>
        /// 目标模板库code
        /// </summary>
        [XmlElement("tgt_template_lib_code")]
        public string TgtTemplateLibCode { get; set; }

        /// <summary>
        /// 目标模板名
        /// </summary>
        [XmlElement("tgt_template_name")]
        public string TgtTemplateName { get; set; }
    }
}
