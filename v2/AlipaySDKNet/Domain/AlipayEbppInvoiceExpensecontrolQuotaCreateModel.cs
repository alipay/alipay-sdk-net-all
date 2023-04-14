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
        /// 企业共同账户id，和授权签约协议号共同使用。
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号，可通过签约消息获取。配合企业共同账户id使用，当填写企业共同账户id时，此字段必填。
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 额度失效时间（格式：yyyy-MM-dd HH:mm:ss），额度类型为点券时必填，额度类型为余额时有默认值，无需填写
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 额度生效时间（格式：yyyy-MM-dd HH:mm:ss），额度类型为点券时必填，额度类型为余额时有默认值，无需填写
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部操作幂等ID（接入方接口调用幂等控制ID），创建额度类型为点券时必填
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 额度所属者ID（未切换open_id请使用此字段）： owner_type为EMPLOYEE时填写员工支付宝ID； owner_type为ENTERPRISE_PAY_UID时填写员工企业码ID； owner_type为PHONE时填写员工手机号； owner_type为ENTERPRISE时填写企业ID。
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 额度所属者ID（切换open_id后请使用此字段）： owner_type为EMPLOYEE时填写open_id； owner_type为ENTERPRISE_PAY_UID时填写员工企业码ID； owner_type为PHONE时填写员工手机号； owner_type为ENTERPRISE时填写企业ID。
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// 额度所属者类型，可通过设置该字段来指定操作的owner_id类型，如果设置企业额度则设置为ENTERPRISE
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 外部平台编码（通常为接入方大写英文缩写）
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 创建额度类型，支持点券和余额，不填写则默认为余额类型
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 额度值，以（分）为单位 约束：个人额度不超过100000元，企业额度不超过100000000元
        /// </summary>
        [XmlElement("quota_value")]
        public string QuotaValue { get; set; }

        /// <summary>
        /// 0:不可转赠（注：不传模式为0） 1:可以转增（注：只有quota_type=COUPON,可设置）
        /// </summary>
        [XmlElement("share_mode")]
        public string ShareMode { get; set; }

        /// <summary>
        /// 额度维度ID 当 target_type=EXPENSE_TYPE 时，值为 MEAL（工作餐） 当target_type=RULE_GROUP_AGGREGATION 时，值为费控规则聚合ID 当target_type=INSTITUTION 时，值为制度ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 额度维度 枚举值： EXPENSE_TYPE（费用类型维度）， RULE_GROUP_AGGREGATION（规则聚合维度）， INSTITUTION（制度维度）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
