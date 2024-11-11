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
        /// 共同账号id（该字段将废弃，不建议使用，可用enterprise_id字段替换） 当前字段已废弃(该字段将废弃，不建议使用，可用enterprise_id字段替换)
        /// </summary>
        [XmlElement("account_id")]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号（该字段将废弃，不建议使用，可用enterprise_id字段替换） 当前字段已废弃(该字段将废弃，不建议使用，可用enterprise_id字段替换)
        /// </summary>
        [XmlElement("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 额度失效时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("effective_end_date")]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 额度生效时间（格式：yyyy-MM-dd HH:mm:ss）
        /// </summary>
        [XmlElement("effective_start_date")]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 批量发放时，可填写该字段
        /// </summary>
        [XmlElement("issue_desc")]
        public string IssueDesc { get; set; }

        /// <summary>
        /// 批量发放时，可填写该字段作为发放名称，如果未填写取outer_source_id为默认值
        /// </summary>
        [XmlElement("issue_name")]
        public string IssueName { get; set; }

        /// <summary>
        /// 外部操作幂等ID，标识创建额度的唯一性，防止重复创建
        /// </summary>
        [XmlElement("outer_source_id")]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 额度所属者ID（未切换open_id请使用此字段）：
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 额度所属者ID（切换open_id后请使用此字段）：
        /// </summary>
        [XmlElement("owner_open_id")]
        public string OwnerOpenId { get; set; }

        /// <summary>
        /// 额度所属者类型
        /// </summary>
        [XmlElement("owner_type")]
        public string OwnerType { get; set; }

        /// <summary>
        /// 外部平台编码（通常为接入方大写英文缩写）
        /// </summary>
        [XmlElement("platform")]
        public string Platform { get; set; }

        /// <summary>
        /// 创建额度类型
        /// </summary>
        [XmlElement("quota_type")]
        public string QuotaType { get; set; }

        /// <summary>
        /// 额度值，以（分）为单位
        /// </summary>
        [XmlElement("quota_value")]
        public string QuotaValue { get; set; }

        /// <summary>
        /// 0:不可转赠 1:可以转增
        /// </summary>
        [XmlElement("share_mode")]
        public string ShareMode { get; set; }

        /// <summary>
        /// 额度维度ID
        /// </summary>
        [XmlElement("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 额度维度 枚举值： INSTITUTION（制度维度）， EXPENSE_TYPE（费用类型维度）
        /// </summary>
        [XmlElement("target_type")]
        public string TargetType { get; set; }
    }
}
