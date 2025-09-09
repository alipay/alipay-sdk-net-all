using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// PlatformPrescriptionStatusExtInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PlatformPrescriptionStatusExtInfo : AopObject
    {
        /// <summary>
        /// 审核失败原因
        /// </summary>
        [XmlElement("audit_fail_reason")]
        public string AuditFailReason { get; set; }

        /// <summary>
        /// 审方药师姓名
        /// </summary>
        [XmlElement("audit_pharmacist_name")]
        public string AuditPharmacistName { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        [XmlElement("audit_time")]
        public string AuditTime { get; set; }

        /// <summary>
        /// 外部审方药师id
        /// </summary>
        [XmlElement("out_audit_pharmacist_id")]
        public string OutAuditPharmacistId { get; set; }
    }
}
