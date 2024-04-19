using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ArInvoiceReceiptQueryOpenApiDTO Data Structure.
    /// </summary>
    [Serializable]
    public class ArInvoiceReceiptQueryOpenApiDTO : AopObject
    {
        /// <summary>
        /// 合约号
        /// </summary>
        [XmlElement("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 开票单据id
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// 我方ou
        /// </summary>
        [XmlElement("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 开票时间
        /// </summary>
        [XmlElement("inv_dt")]
        public string InvDt { get; set; }

        /// <summary>
        /// 开票模式 01 实收开票 02 应收开票 03 累计实收开票
        /// </summary>
        [XmlElement("inv_mode")]
        public string InvMode { get; set; }

        /// <summary>
        /// 可开票金额
        /// </summary>
        [XmlElement("invoice_amt")]
        public MultiCurrencyMoneyOpenApi InvoiceAmt { get; set; }

        /// <summary>
        /// 已开票金额
        /// </summary>
        [XmlElement("invoiced_amt")]
        public MultiCurrencyMoneyOpenApi InvoicedAmt { get; set; }

        /// <summary>
        /// 商户号（可能为空）
        /// </summary>
        [XmlElement("ip_id")]
        public string IpId { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 已关联发票金额
        /// </summary>
        [XmlElement("link_invoice_amt")]
        public MultiCurrencyMoneyOpenApi LinkInvoiceAmt { get; set; }

        /// <summary>
        /// 外部单据号（对应月账单号或者结算单号）
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [XmlElement("pd_code")]
        public string PdCode { get; set; }

        /// <summary>
        /// 结算类型  01实时，02预收 03后收 04周期性 05按日汇总 06周期性 09 延期结算
        /// </summary>
        [XmlElement("settle_type")]
        public string SettleType { get; set; }

        /// <summary>
        /// 对账单号
        /// </summary>
        [XmlElement("statement_bill_no")]
        public string StatementBillNo { get; set; }

        /// <summary>
        /// 开票状态 01 未开票 02 部分开票 03 完全开票
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        [XmlElement("tax_rate")]
        public long TaxRate { get; set; }

        /// <summary>
        /// 税种 01 增值税 02 营业税
        /// </summary>
        [XmlElement("tax_type")]
        public string TaxType { get; set; }
    }
}
