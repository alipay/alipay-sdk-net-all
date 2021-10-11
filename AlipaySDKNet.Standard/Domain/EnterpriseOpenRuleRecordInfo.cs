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
        /// 开票规则生效日期
        /// </summary>
        [XmlElement("effective_start")]
        public string EffectiveStart { get; set; }

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
        /// 开票规则id
        /// </summary>
        [XmlElement("invoice_rule_id")]
        public string InvoiceRuleId { get; set; }

        /// <summary>
        /// 开票规则记录id
        /// </summary>
        [XmlElement("invoice_rule_record_id")]
        public string InvoiceRuleRecordId { get; set; }

        /// <summary>
        /// 发票抬头id
        /// </summary>
        [XmlElement("invoice_title_id")]
        public string InvoiceTitleId { get; set; }

        /// <summary>
        /// 开票申请方：ENTERPRISE（企业发起），EMPLOYEE（员工发起）
        /// </summary>
        [XmlElement("open_applyer")]
        public string OpenApplyer { get; set; }

        /// <summary>
        /// 开票模式：汇总开、笔笔开 枚举定义：SUMMARY:汇总开 SINGLE:单笔开
        /// </summary>
        [XmlElement("open_mode")]
        public string OpenMode { get; set; }

        /// <summary>
        /// 开票申请类型：AUTO（自动开票），MANUAL（手动开票）
        /// </summary>
        [XmlElement("open_type")]
        public string OpenType { get; set; }

        /// <summary>
        /// 所有者id（企业情况下=enterpriseId）
        /// </summary>
        [XmlElement("owner_id")]
        public string OwnerId { get; set; }
    }
}
