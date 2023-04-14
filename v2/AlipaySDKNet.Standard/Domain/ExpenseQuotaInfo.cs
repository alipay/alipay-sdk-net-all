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
        /// 额度失效时间
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 额度生效时间
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 额度是否冻结，冻结后因公付不可用
        /// </summary>
        [XmlElement("freeze")]
        public bool Freeze { get; set; }

        /// <summary>
        /// 切换open_id前请使用：额度所属者ID owner_type为EMPLOYEE时为员工支付宝ID owner_type为ENTERPRISE_PAY_UID时为员工企业码ID owner_type为PHONE时为员工手机号 owner_type为ENTERPRISE时为企业ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 切换open_id后请使用：额度所属者ID owner_type为EMPLOYEE时为员工open_id owner_type为PHONE时为员工手机号 owner_type为ENTERPRISE_PAY_UID时为员工企业码ID
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// 额度所属者id类型 EMPLOYEE 员工
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 可用金额（单位分）
        /// </summary>
        [XmlElement("quota_available")]
        public string QuotaAvailable { get; set; }

        /// <summary>
        /// 额度ID
        /// </summary>
        [XmlElement("quota_id")]
        public string QuotaId { get; set; }

        /// <summary>
        /// 锁定金额（单位分）
        /// </summary>
        [XmlElement("quota_locked")]
        public string QuotaLocked { get; set; }

        /// <summary>
        /// 总金额（单位分）
        /// </summary>
        [XmlElement("quota_total")]
        public string QuotaTotal { get; set; }

        /// <summary>
        /// 额度类型
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 已用金额（单位分）
        /// </summary>
        [XmlElement("quota_used")]
        public string QuotaUsed { get; set; }

        /// <summary>
        /// 额度维度ID 当 target_type=EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type=RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID 当target_type=INSTITUTION 时，值为制度ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 额度维度 枚举值： EXPENSE_TYPE（费用类型维度）， RULE_GROUP_AGGREGATION（规则聚合维度）, INSTITUTION（制度）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
