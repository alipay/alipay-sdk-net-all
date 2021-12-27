using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ExpenseQuotaInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ExpenseQuotaInfo : AopObject
    {
        /// <summary>
        /// 余额失效时间
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 余额生效时间
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 余额是否冻结，冻结后因公付不可用
        /// </summary>
        [XmlElement("freeze")]
        public bool Freeze { get; set; }

        /// <summary>
        /// 余额所属者ID owner_type为员工时为员工支付宝ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 余额所属者类型 EMPLOYEE 员工
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 可用余额（单位分）
        /// </summary>
        [XmlElement("quota_available")]
        public string QuotaAvailable { get; set; }

        /// <summary>
        /// 余额ID
        /// </summary>
        [XmlElement("quota_id")]
        public string QuotaId { get; set; }

        /// <summary>
        /// 锁定余额（单位分）
        /// </summary>
        [XmlElement("quota_locked")]
        public string QuotaLocked { get; set; }

        /// <summary>
        /// 总余额（单位分）
        /// </summary>
        [XmlElement("quota_total")]
        public string QuotaTotal { get; set; }

        /// <summary>
        /// 已用余额（单位分）
        /// </summary>
        [XmlElement("quota_used")]
        public string QuotaUsed { get; set; }

        /// <summary>
        /// 余额维度ID 当 target_type=EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type=RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 余额维度 枚举值： EXPENSE_TYPE（费用类型维度）， RULE_GROUP_AGGREGATION（规则聚合维度）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
