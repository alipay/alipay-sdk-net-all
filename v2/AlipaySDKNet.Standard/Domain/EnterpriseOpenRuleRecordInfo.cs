using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// EnterpriseOpenRuleRecordInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EnterpriseOpenRuleRecordInfo : AopObject
    {
        /// <summary>
        /// 开票规则账单日
        /// </summary>
        [XmlElement("bill_month_day")]
        public long BillMonthDay { get; set; }

        /// <summary>
        /// 开票账单范围
        /// </summary>
        [XmlElement("bill_scope")]
        public string BillScope { get; set; }

        /// <summary>
        /// 组合支付模式
        /// </summary>
        [XmlElement("combined_pay_mode")]
        public string CombinedPayMode { get; set; }

        /// <summary>
        /// 默认开票类型
        /// </summary>
        [XmlElement("default_invoice_kind")]
        public string DefaultInvoiceKind { get; set; }

        /// <summary>
        /// 开票规则生效日期
        /// </summary>
        [XmlElement("effective_start")]
        public string EffectiveStart { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [XmlElement("gmt_modified")]
        public string GmtModified { get; set; }

        /// <summary>
        /// 开票规则的发票备注取值规则。NONE表示不使用额度发放说明；QUOTA_ISSUE_DESC表示将因公付额度发放说明作为发票备注。历史规则未配置时按NONE理解。
        /// </summary>
        [XmlElement("invoice_remark_value_rule")]
        public string InvoiceRemarkValueRule { get; set; }

        /// <summary>
        /// 开票规则ID
        /// </summary>
        [XmlElement("invoice_rule_id")]
        public string InvoiceRuleId { get; set; }

        /// <summary>
        /// 开票规则记录ID
        /// </summary>
        [XmlElement("invoice_rule_record_id")]
        public string InvoiceRuleRecordId { get; set; }

        /// <summary>
        /// 发票抬头id
        /// </summary>
        [XmlElement("invoice_title_id")]
        public string InvoiceTitleId { get; set; }

        /// <summary>
        /// 开票申请方
        /// </summary>
        [XmlElement("open_applyer")]
        public string OpenApplyer { get; set; }

        /// <summary>
        /// 开票模式
        /// </summary>
        [XmlElement("open_mode")]
        public string OpenMode { get; set; }

        /// <summary>
        /// 开票申请类型
        /// </summary>
        [XmlElement("open_type")]
        public string OpenType { get; set; }

        /// <summary>
        /// 企业共同账户ID
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 开票规则标记
        /// </summary>
        [XmlElement("tag")]
        public string Tag { get; set; }
    }
}
