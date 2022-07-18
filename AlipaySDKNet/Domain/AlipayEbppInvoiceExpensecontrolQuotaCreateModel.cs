using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceExpensecontrolQuotaCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppInvoiceExpensecontrolQuotaCreateModel : AopObject
    {
        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 余额失效时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 余额生效时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部操作幂等ID（接入方接口调用幂等控制ID）
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 余额所属者ID owner_type为EMPLOYEE时为员工支付宝ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 余额所属者类型 EMPLOYEE: 员工
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 外部平台编码（通常为接入方大写英文缩写）
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 余额，以（分）为单位 约束：余额不超过100000元
        /// </summary>
        [XmlElement("quota_value")]
        public string QuotaValue { get; set; }

        /// <summary>
        /// 余额维度ID 当 target_type=EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type=RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 余额维度 枚举值： EXPENSE_TYPE（费用类型维度）， RULE_GROUP_AGGREGATION（规则聚合维度
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
