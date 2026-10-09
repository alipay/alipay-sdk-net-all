using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityProdTemplateVersionCopyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityProdTemplateVersionCopyModel : AopObject
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
        /// 租户
        /// </summary>
        [XmlElement("tenant")]
        public string Tenant { get; set; }

        /// <summary>
        /// 模板版本唯一标识
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
