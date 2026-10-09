using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceDTO Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceDTO : AopObject
    {
        /// <summary>
        /// 票面金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 审批时间
        /// </summary>
        [XmlElement("approve_date")]
        public string ApproveDate { get; set; }

        /// <summary>
        /// 审批人
        /// </summary>
        [XmlElement("approved_by")]
        public string ApprovedBy { get; set; }

        /// <summary>
        /// 归档号
        /// </summary>
        [XmlElement("archive_no")]
        public string ArchiveNo { get; set; }

        /// <summary>
        /// 发票归档状态
        /// </summary>
        [XmlElement("archive_status")]
        public string ArchiveStatus { get; set; }

        /// <summary>
        /// 业务身份
        /// </summary>
        [XmlElement("biz_id")]
        public long BizId { get; set; }

        /// <summary>
        /// 确认时间
        /// </summary>
        [XmlElement("confirm_date")]
        public string ConfirmDate { get; set; }

        /// <summary>
        /// 确认方式
        /// </summary>
        [XmlElement("confirm_way")]
        public string ConfirmWay { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [XmlElement("create_date")]
        public string CreateDate { get; set; }

        /// <summary>
        /// 发票币种
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 发票描述状态
        /// </summary>
        [XmlElement("desc_status")]
        public string DescStatus { get; set; }

        /// <summary>
        /// 废弃金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("discard_amount")]
        public string DiscardAmount { get; set; }

        /// <summary>
        /// 分发发票ID
        /// </summary>
        [XmlElement("distribute_invoice_id")]
        public string DistributeInvoiceId { get; set; }

        /// <summary>
        /// 生效状态
        /// </summary>
        [XmlElement("effect_status")]
        public string EffectStatus { get; set; }

        /// <summary>
        /// 录入时间
        /// </summary>
        [XmlElement("entry_date")]
        public string EntryDate { get; set; }

        /// <summary>
        /// 发票录入人
        /// </summary>
        [XmlElement("entry_user")]
        public string EntryUser { get; set; }

        /// <summary>
        /// 不含税金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("excluding_tax_amount")]
        public string ExcludingTaxAmount { get; set; }

        /// <summary>
        /// ext信息
        /// </summary>
        [XmlElement("ext_json")]
        public string ExtJson { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票主键ID
        /// </summary>
        [XmlElement("invoice_id")]
        public long InvoiceId { get; set; }

        /// <summary>
        /// 发票编号
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票状态：UN_CONFIRM（未确认）,CONFIRMED（已确认）,RETURNED(退票）
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 发票类型(VAT，COMMON)
        /// </summary>
        [XmlElement("invoice_type")]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 组织ID
        /// </summary>
        [XmlElement("org_id")]
        public long OrgId { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        [XmlElement("ou_code")]
        public string OuCode { get; set; }

        /// <summary>
        /// 是否红票
        /// </summary>
        [XmlElement("red")]
        public bool Red { get; set; }

        /// <summary>
        /// 登记日期
        /// </summary>
        [XmlElement("reg_date")]
        public string RegDate { get; set; }

        /// <summary>
        /// 退票人
        /// </summary>
        [XmlElement("return_by")]
        public string ReturnBy { get; set; }

        /// <summary>
        /// 退票时间
        /// </summary>
        [XmlElement("return_date")]
        public string ReturnDate { get; set; }

        /// <summary>
        /// 退票原因
        /// </summary>
        [XmlElement("return_reason")]
        public string ReturnReason { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [XmlElement("source_system")]
        public string SourceSystem { get; set; }

        /// <summary>
        /// 来源ID
        /// </summary>
        [XmlElement("source_unique_no")]
        public string SourceUniqueNo { get; set; }

        /// <summary>
        /// 税额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("tax_amount")]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 实物发票ID
        /// </summary>
        [XmlElement("tax_invoice_id")]
        public string TaxInvoiceId { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public string TaxRate { get; set; }

        /// <summary>
        /// 快递单号
        /// </summary>
        [XmlElement("tracking_no")]
        public string TrackingNo { get; set; }

        /// <summary>
        /// 使用金额（单位：各币种的“元”单位，精确到小数点后2位）
        /// </summary>
        [XmlElement("use_amount")]
        public string UseAmount { get; set; }

        /// <summary>
        /// 销方
        /// </summary>
        [XmlElement("vendor_id")]
        public long VendorId { get; set; }

        /// <summary>
        /// 认证时间
        /// </summary>
        [XmlElement("verify_date")]
        public string VerifyDate { get; set; }

        /// <summary>
        /// 认证周期，YYYYMM格式
        /// </summary>
        [XmlElement("verify_period")]
        public string VerifyPeriod { get; set; }

        /// <summary>
        /// 认证状态
        /// </summary>
        [XmlElement("verify_status")]
        public string VerifyStatus { get; set; }
    }
}
