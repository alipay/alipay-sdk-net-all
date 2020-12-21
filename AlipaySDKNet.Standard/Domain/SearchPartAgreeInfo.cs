using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SearchPartAgreeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SearchPartAgreeInfo : AopObject
    {
        /// <summary>
        /// 剔除数据名称
        /// </summary>
        [XmlElement("audit_info")]
        public string AuditInfo { get; set; }

        /// <summary>
        /// 剔除数据的operator信息
        /// </summary>
        [XmlElement("audit_operator")]
        public string AuditOperator { get; set; }

        /// <summary>
        /// 剔除原因
        /// </summary>
        [XmlElement("audit_reason")]
        public string AuditReason { get; set; }

        /// <summary>
        /// 剔除数据类型
        /// </summary>
        [XmlElement("audit_type")]
        public string AuditType { get; set; }
    }
}
