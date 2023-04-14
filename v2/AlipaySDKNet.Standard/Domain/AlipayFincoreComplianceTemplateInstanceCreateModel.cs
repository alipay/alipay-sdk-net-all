using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayFincoreComplianceTemplateInstanceCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFincoreComplianceTemplateInstanceCreateModel : AopObject
    {
        /// <summary>
        /// 业务单据号
        /// </summary>
        [XmlElement("biz_business_id")]
        public string BizBusinessId { get; set; }

        /// <summary>
        /// 业务要素字段
        /// </summary>
        [XmlElement("biz_object_def_json")]
        public string BizObjectDefJson { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [XmlElement("emp_id")]
        public string EmpId { get; set; }

        /// <summary>
        /// 员工名称
        /// </summary>
        [XmlElement("emp_name")]
        public string EmpName { get; set; }

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
