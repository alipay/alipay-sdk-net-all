using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ActivityMerchantOrder Data Structure.
    /// </summary>
    [Serializable]
    public class ActivityMerchantOrder : AopObject
    {
        /// <summary>
        /// 活动类型
        /// </summary>
        [XmlElement("activity_type")]
        public string ActivityType { get; set; }

        /// <summary>
        /// 审核结果，99通过，-1失败，901审核中
        /// </summary>
        [XmlElement("audit_result")]
        public string AuditResult { get; set; }

        /// <summary>
        /// 失败理由
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 申请单ID
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 费率申请通过后实际生效的费率值，只有0或者0.001两种可能情况。当status字段返回TRUE时此字段有值，反之不返回费率信息
        /// </summary>
        [XmlElement("rate")]
        public string Rate { get; set; }
    }
}
